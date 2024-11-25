using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public override void Add(User entitiy)
        {
            string query = "Insert Into Users (Name,Email,Password,Role) Values (@Name,@Email,@Password,@Role)";
            //Builder design pattern kullandık

            //SqlParameter[] sp = new SqlParameter[] {
            // new SqlParameter("@Name",entitiy.Name),
            // new SqlParameter("@Email",entitiy.Email),
            // new SqlParameter("@Password",entitiy.Password),
            // new SqlParameter("@Role",entitiy.Role)
            //};
            var sp = new SqlParameterBuilder()
                .AddParameter("@Name", entitiy.Name)
                .AddParameter("@Email", entitiy.Email)
                .AddParameter("@Password", entitiy.Password)
                .AddParameter("@Role", entitiy.Role)
                .Build();

            ExecuteNonQuery(query, sp);
        }

        public override void Delete(int id)
        {
            string query = "Delete From Users Where Id= @Id ";
            //SqlParameter[] sp = new SqlParameter[] {
            // new SqlParameter("@Id",id),

            //};
            var sp = new SqlParameterBuilder()
               .AddParameter("@Id", id)
               .Build();
            ExecuteNonQuery(query, sp);
        }

        public override void Delete(User entitiy)
        {
            string query = "Delete From Users Where Id= @Id ";
            //SqlParameter[] sp = new SqlParameter[] {
            // new SqlParameter("@Id",entitiy.Id),

            //};
            var sp = new SqlParameterBuilder()
               .AddParameter("@Id", entitiy.Id)
               .Build();
            ExecuteNonQuery(query, sp);
        }

        public override List<User> GetAll()
        {
            string query = "Select * from Users";
            DataTable dataTable = ExecuteQuery(query);
            List<User> users = new List<User>();
            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(DataMappers.MapToUser(row));
            }
            return users;
        }

        public override User GetById(int id)
        {
            string query = "Select * from Users Where Id=@Id";
            //SqlParameter[] sp = new SqlParameter[] {new SqlParameter("@Id",id)};
            var sp = new SqlParameterBuilder()
               .AddParameter("@Id", id)
               .Build();
            DataTable dataTable = ExecuteQuery(query, sp);

            if (dataTable.Rows.Count == 0)
                return null;
            DataRow row = dataTable.Rows[0];

            return DataMappers.MapToUser(row);


        }

        public override void Update(User entitiy)
        {
            string query = "Update Users Set Name=@Name,Email=@Email,Password=@PassWord,Role=@Role Where Id= @Id ";
            //SqlParameter[] sp = new SqlParameter[] {
            // new SqlParameter("@Id",entitiy.Id),
            // new SqlParameter("@Name",entitiy.Name),
            // new SqlParameter("@Email",entitiy.Email),
            // new SqlParameter("@Password",entitiy.Password),
            // new SqlParameter("@Role",entitiy.Role)
            //};

            var sp = new SqlParameterBuilder()
                .AddParameter("@Id", entitiy.Id)
               .AddParameter("@Name", entitiy.Name)
               .AddParameter("@Email", entitiy.Email)
               .AddParameter("@Password", entitiy.Password)
               .AddParameter("@Role", entitiy.Role)
               .Build();
            ExecuteNonQuery(query, sp);
        }

        public (bool,int?) Login(string username, string password)
        {
            string query = "Select * from Users where Name = @Name and Password=@Password";
            var sp = new SqlParameterBuilder()
              .AddParameter("@Name", username)
              .AddParameter("@Password", password)
              .Build();
            var dataTable = ExecuteQuery(query, sp);
            if(dataTable.Rows.Count == 0)
                return (false,null);
            var id = (int)dataTable.Rows[0]["Id"];

            return (true,id);
        }

    }
}
