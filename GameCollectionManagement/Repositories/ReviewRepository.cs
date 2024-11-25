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
    public class ReviewRepository : BaseRepository<Review>
    {
        public override List<Review> GetAll()
        {
            string query = "Select * from Reviews";
            DataTable dt = ExecuteQuery(query);
            List<Review> reviews = new List<Review>();
            foreach (DataRow dr in dt.Rows)
            {
                reviews.Add(DataMappers.MapToReview(dr));
            }
            return reviews;
        }
        public List<Review> GetAllByRole(string role, int userId)
        {
            if(role.ToLower() == "admin")
            {
                return GetAll();
            }
            string query = "Select * from Reviews Where UserId= @UserId";
            var parameters= new SqlParameterBuilder().AddParameter("@UserId", userId).Build();
            DataTable dt = ExecuteQuery(query,parameters);
            List<Review> reviews = new List<Review>();
            foreach (DataRow dr in dt.Rows)
            {
                reviews.Add(DataMappers.MapToReview(dr));
            }
            return reviews;
        }

        public override Review GetById(int id)
        {
            string query = "Select * from Reviews Where Id=@Id";

            //SqlParameter[] parameters = new SqlParameter[] {
            //    new SqlParameter("@Id",id) };
            var parameters = new SqlParameterBuilder()
              .AddParameter("@Id", id)
              .Build();

            DataTable dt = ExecuteQuery(query, parameters);
            if (dt.Rows.Count == 0) return null;
            DataRow dr = dt.Rows[0];
            return DataMappers.MapToReview(dr);
        }
        public override void Add(Review entitiy)
        {
            string query = "Insert Into Reviews (GameId,UserId,ReViewText,Rating) Values(@GameId,@UserId,@ReViewText,@Rating)";
            //SqlParameter[] parameters = new SqlParameter[] {
            // new SqlParameter("@GameId",entitiy.GameId),
            // new SqlParameter("@UserId",entitiy.UserId),
            // new SqlParameter("@ReviewText",entitiy.ReviewText),
            // new SqlParameter("@Rating",entitiy.Rating)

            //};
            var parameters = new SqlParameterBuilder()
              .AddParameter("@GameId", entitiy.GameId)
              .AddParameter("@UserId", entitiy.UserId)
              .AddParameter("@ReviewText", entitiy.ReviewText)
              .AddParameter("@Rating", entitiy.Rating)
              .Build();
            ExecuteNonQuery(query, parameters);

        }

        public override void Update(Review entitiy)
        {
            string query = "Update Reviews Set GameId=@GameId,UserId=@UserId,ReViewText=@ReviewText,Rating=@Rating where Id=@Id ";
            //SqlParameter[] parameters = new SqlParameter[] {
            // new SqlParameter("@Id",entitiy.Id),
            // new SqlParameter("@GameId",entitiy.GameId),
            // new SqlParameter("@UserId",entitiy.UserId),
            // new SqlParameter("@ReviewText",entitiy.ReviewText),
            // new SqlParameter("@Rating",entitiy.Rating)

            //};
            var parameters = new SqlParameterBuilder()
             .AddParameter("@Id", entitiy.Id)
             .AddParameter("@GameId", entitiy.GameId)
             .AddParameter("@UserId", entitiy.UserId)
             .AddParameter("@ReviewText", entitiy.ReviewText)
             .AddParameter("@Rating", entitiy.Rating)
             .Build();
            ExecuteNonQuery(query, parameters);

        }

        public override void Delete(int id)
        {
            string query = "Delete From Reviews where Id=@Id ";

            var parameters = new SqlParameterBuilder()
            .AddParameter("@Id", id)
            .Build();
            ExecuteNonQuery(query, parameters);
        }
        public override void Delete(Review entitiy)
        {
            Delete(entitiy.Id);
        }

        public  void DeleteByRole(int reviewId,string role,int userId)
        {
            if(role.ToLower() != "admin")
            {
                var review = GetById(reviewId);
                if (review.UserId != userId)
                    return;
            }
            Delete(reviewId);
        }

        public List<Review> GetAllReviewDetail()
        {
            string query = "Select R.*, U.Name, U.Email,U.Password,U.Role,G.Name,G.Genre,G.Platform,G.ReleaseDate,G.CoverImage from Reviews R inner join Users U on R.UserId= U.Id inner join Games G on G.Id= R.GameId";
            DataTable dt = ExecuteQuery(query);
            List<Review> reviews = new List<Review>();

            foreach (DataRow dr in dt.Rows)
            {
                /* reviews.Add(new Review
                 {
                     Id = Convert.ToInt32(dr["Id"]),
                     GameId = Convert.ToInt32(dr["GameId"]),
                     UserId = Convert.ToInt32(dr["UserId"]),
                     ReviewText = dr["ReviewText"].ToString(),
                     Rating = Convert.ToInt32(dr["Rating"]),
                     Game = new Game
                     {
                         Id = Convert.ToInt32(dr["GameId"]),
                         Name = dr["Name"].ToString(),
                         Genre = dr["Genre"].ToString(),
                         Platform = dr["Platform"].ToString(),
                         ReleaseDate = Convert.ToDateTime(dr["ReleaseDate"]),
                         CoverImage = dr["CoverImage"] as byte[]
                     },
                     User = new User
                     {
                         Id = Convert.ToInt32(dr["UserId"]),
                         Name = dr["Name"].ToString(),
                         Email = dr["Email"].ToString(),
                         Password = dr["Password"].ToString(),
                         Role = dr["Role"].ToString()


                     }

                 });*/
                reviews.Add(DataMappers.MapToReviewDetails(dr));
            }
            return reviews;
        }

        public Review GetByIdReviewDetails(int id)
        {
            string query = "Select R.*, U.Name, U.Email,U.Password,U.Role,G.Name,G.Genre,G.Platform,G.ReleaseDate,G.CoverImage from Reviews R inner join Users U on R.UserId= U.Id inner join Games G on G.Id= R.GameId where Id=@Id";

            var parameters = new SqlParameterBuilder()
            .AddParameter("@Id", id)
            .Build();
            var dataTable = ExecuteQuery(query, parameters);
            if (dataTable.Rows.Count == 0) return null;
            DataRow dr = dataTable.Rows[0];
            return DataMappers.MapToReviewDetails(dr);


        }
    }
}
/*.*/
