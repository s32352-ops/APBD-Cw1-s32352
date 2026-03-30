
using System.Collections.Generic;
using System.Linq;
using EquipmentRental.Enums;
using EquipmentRental.Exceptions;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly List<Equipment> _equipment = new List<Equipment>();

        public void AddEquipment(Equipment equipment)
        {
            _equipment.Add(equipment);
        }

        public List<Equipment> GetAll() => _equipment;

        public List<Equipment> GetAvailable() =>
            _equipment.Where(e => e.Status == EquipmentStatus.Available).ToList();

        public Equipment GetById(int id)
        {
            var eq = _equipment.FirstOrDefault(e => e.Id == id);
            if (eq == null)
                throw new EquipmentNotFoundException(id);

            return eq;
        }

        public void SetUnavailable(int id)
        {
            var eq = GetById(id);
            eq.Status = EquipmentStatus.Unavailable;
        }
    }
}