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
    public class GameRepository : BaseRepository<Game>
    {
        public override List<Game> GetAll()
        {
            string query = "Select * from Games";
            DataTable dt = ExecuteQuery(query);
            List<Game> games = new List<Game>();

            foreach (DataRow dr in dt.Rows)
            {
                //Game game = new Game();
                //game.Id = Convert.ToInt32(dr["Id"]);
                //game.Name = dr["Name"].ToString();
                //game.Genre = dr["Genre"].ToString();
                //game.Platform = dr["Platform"].ToString();
                //game.ReleaseDate = Convert.ToDateTime(dr["ReleaseDate"]);
                //game.PlayTime = Convert.ToInt32(dr["PlayTime"]);
                //game.CoverImage = dr["CoverImage"] as byte[];
                games.Add(DataMappers.MapToGame(dr));

            }
            return games;
        }

        // daha hızlı versiyonu ise data reader ile olandır
        public List<Game> GetList()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from Games", connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Game> games = new List<Game>();
                while (reader.Read())
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.Name = reader["Name"].ToString();
                    game.Genre = reader["Genre"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    game.PlayTime = Convert.ToInt32(reader["PlayTime"]);
                    game.CoverImage = reader["CoverImage"] as byte[];
                    games.Add(game);

                }
                reader.Close();
                return games;
            }
        }

        public override Game GetById(int id)
        {
            string query = "Select * from Games Where Id=@Id";
            DataTable dt = ExecuteQuery(query, new SqlParameter[] {
            new SqlParameter("@Id",id)
            });

            DataRow dr = dt.Rows[0];
            return DataMappers.MapToGame(dr);
        }

        public override void Add(Game entitiy)
        {
            string query = "Insert into Games(Name,Genre,Platform,ReleaseDate,PlayTime,CoverImage) values (@Name,@Genre,@Platform,@ReleaseDate,@PlayTime,@CoverImage)";
            //SqlParameter[] parameters = new SqlParameter[] {
            // new SqlParameter("@Name",entitiy.Name),
            // new SqlParameter("@Genre",entitiy.Genre),
            // new SqlParameter("@Platform",entitiy.Platform),
            // new SqlParameter("@ReleaseDate",entitiy.ReleaseDate),
            // new SqlParameter("@PlayTime",entitiy.PlayTime),
            // new SqlParameter("@CoverImage",entitiy.CoverImage)
            //};
            var parameters = new SqlParameterBuilder()
            .AddParameter("@Name", entitiy.Name)
            .AddParameter("@Genre", entitiy.Genre)
            .AddParameter("@Platform", entitiy.Platform)
            .AddParameter("@ReleaseDate", entitiy.ReleaseDate)
            .AddParameter("@PlayTime", entitiy.PlayTime)
            .AddParameterWithValue("@CoverImage", entitiy.CoverImage,SqlDbType.VarBinary)
            .Build();
            ExecuteNonQuery(query, parameters);
        }

        public override void Update(Game entitiy)
        {
            string query = "Update Games Set Name = @Name,Genre = @Genre,Platform=@Platform,ReleaseDate=@ReleaseDate,PlayTime=@PlayTime,CoverImage=@CoverImage Where Id=@Id ";

            var parameters = new SqlParameterBuilder()
        .AddParameter("@Id", entitiy.Id)
        .AddParameter("@Name", entitiy.Name)
        .AddParameter("@Genre", entitiy.Genre)
        .AddParameter("@Platform", entitiy.Platform)
        .AddParameter("@ReleaseDate", entitiy.ReleaseDate)
        .AddParameter("@PlayTime", entitiy.PlayTime)
        .AddParameterWithValue("@CoverImage", entitiy.CoverImage, SqlDbType.VarBinary)
        .Build();

            ExecuteNonQuery(query, parameters);
        }
        public override void Delete(int id)
        {
            string query = "Delete from  Games Where Id= @Id";
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
      .AddParameter("@Id", id)
      .Build();
            ExecuteNonQuery(query, parameters);

        }

        public override void Delete(Game entitiy)
        {

            string query = "Delete from  Games Where Id= @Id";
            var parameters = new SqlParameterBuilder()
      .AddParameter("@Id", entitiy.Id)
      .Build();
            ExecuteNonQuery(query, parameters);
        }
        public List<string> GetGenres()
        {
            var games = GetAll();
            List<string> genres = new List<string>();
            foreach (var game in games)
            {
                if (!genres.Contains(game.Genre))
                    genres.Add(game.Genre);
            }
            return genres;
        }
    }
}
