using GameCollectionManagement.Models;
using GameCollectionManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public void Add(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name)) 
            {
                throw new ArgumentException("Kullanıcı ismi boş bırakılamaz");
            }
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email boş bırakılamaz");
            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                throw new ArgumentException("Şifre alanı boş bırakılamaz");
            }
            _userRepository.Add(user);

        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Geçersiz id girişi");
            }
            var user = _userRepository.GetById(id);
            if (user is not null)
            {
                _userRepository.Delete(user);
            }
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
           return _userRepository.GetById(id);
        }

        public (bool isAuthenticated, int? userId) Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Kullancı adı ve ya şifre boş bırakılamaz");
            }
            return _userRepository.Login(username, password);
        }

        public void Update(User user)
        {
            if (user.Id <= 0)
            {
                throw new ArgumentException("Geçersiz kullanıcı id");
            }
            var currentUser = _userRepository.GetById(user.Id);

            if (currentUser is not null)
            {
                _userRepository.Update(user);
            }
        }
        public List<User> Search(string searchTerm)
        {
            var users = _userRepository.GetAll().Where(x=> x.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || x.Email.Contains(searchTerm,StringComparison.OrdinalIgnoreCase)).ToList();
            return users;
        }
    }
}
