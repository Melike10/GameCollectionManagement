using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Models.Mappers
{
    public class DataMappers
    {
        public static Review MapToReview(DataRow dr)
        {
            return new Review
            {
                Id = Convert.ToInt32(dr["Id"]),
                GameId = Convert.ToInt32(dr["GameId"]),
                UserId = Convert.ToInt32(dr["UserId"]),
                ReviewText = dr["ReviewText"].ToString(),
                Rating = Convert.ToInt32(dr["Rating"])
            };
        }

        public static Review MapToReviewDetails(DataRow dr)
        {
            //Review review = MapToReview(dr);
            //review.User = MapToUser(dr);
            //review.Game = MapToGame(dr);
           return  new Review
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

            };
            
        }
        public static Game MapToGame(DataRow dr)
        {
            Game game = new Game();
            game.Id = Convert.ToInt32(dr["Id"]);
            game.Name = dr["Name"].ToString();
            game.Genre = dr["Genre"].ToString();
            game.Platform = dr["Platform"].ToString();
            game.ReleaseDate = Convert.ToDateTime(dr["ReleaseDate"]);
            game.PlayTime = Convert.ToInt32(dr["PlayTime"]);
            game.CoverImage = dr["CoverImage"] as byte[];


            return game;
        }

        public static User MapToUser(DataRow dr)
        {
            return new User
            {
                Id = Convert.ToInt32(dr["Id"]),
                Name = dr["Name"].ToString(),
                Email = dr["Email"].ToString(),
                Password = dr["Password"].ToString(),
                Role = dr["Role"].ToString()
            };
        }
    }
}
