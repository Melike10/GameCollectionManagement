using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected string _connectionString = @"Server=DESKTOP-NKTDPLS\SQLEXPRESS;Database=GameCollectionManagement;Trusted_Connection=true";
        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract void Add(T entitiy);
        public abstract void Update(T entitiy);
        public abstract void Delete(int id);
        public abstract void Delete(T entitiy);

        protected DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            // using sayesiinde kaynakaları iyi yönetiriz
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        protected int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteNonQuery();

            }
        }

    }
}
