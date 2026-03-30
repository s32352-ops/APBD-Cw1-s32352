using System.Collections.Generic;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public interface IUserService
    {
        void AddUser(User user);
        List<User> GetAll();
        User GetById(int id);
    }
}