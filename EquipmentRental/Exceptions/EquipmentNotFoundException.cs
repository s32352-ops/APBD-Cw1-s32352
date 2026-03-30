using System;

namespace EquipmentRental.Exceptions
{
    public class EquipmentNotFoundException : Exception
    {
        public EquipmentNotFoundException(int id)
            : base($"Equipment with id {id} not found") { }
    }
}