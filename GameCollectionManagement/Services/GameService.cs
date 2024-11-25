using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class GameService : IGameService
    {
        private readonly GameRepository _gameRepository;
        public GameService()
        {
           _gameRepository = new GameRepository();
                
        }

        public void Add(Game game)
        {
            if (string.IsNullOrWhiteSpace(game.Name))
                throw new ArgumentException("Oyun adı alanı boş bırakılamaz");
            _gameRepository.Add(game);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Geçersiz Id");
            var game = _gameRepository.GetById(id);
            if (game is not null)
              _gameRepository.Delete(game);
        }

        public List<Game> GetAll()
        {
            return _gameRepository.GetAll();
        }


        public List<Game> GetByGenre(string genre)
        {
            return GetAll().Where(g=>g.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Game GetById(int id)
        {
            return _gameRepository.GetById(id);
        }

        public List<string> GetGenres()
        {
            return _gameRepository.GetGenres();
        }

        public List<Game> Search(string search)
        {
            return GetAll().Where(g=> g.Name.Contains(search,StringComparison.OrdinalIgnoreCase) 
                                 || g.Platform.Contains(search,StringComparison.OrdinalIgnoreCase) 
                                 || g.Genre.Contains(search,StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public int TotalCount()
        {
            return GetAll().Count();
        }

        public void Update(Game game)
        {
            if (game.Id <= 0)
                throw new ArgumentException("Geçersiz Id");
            var currentGame = _gameRepository.GetById(game.Id);

            if (currentGame is not null)
             _gameRepository.Update(game);
        }
        
    }
}
