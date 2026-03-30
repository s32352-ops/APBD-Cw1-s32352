
using System.Collections.Generic;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public interface IEquipmentService
    {
        void AddEquipment(Equipment equipment);
        List<Equipment> GetAll();
        List<Equipment> GetAvailable();
        Equipment GetById(int id);
        void SetUnavailable(int id);
    }
}