using System.Collections.Generic;
using System.Linq;
using EquipmentRental.Exceptions;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetAll() => _users;

        public User GetById(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                throw new UserNotFoundException(id);

            return user;
        }
    }
}