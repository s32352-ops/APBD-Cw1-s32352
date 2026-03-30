using System;

namespace EquipmentRental.Exceptions
{
    public class RentalNotFoundException : Exception
    {
        public RentalNotFoundException() : base("Rental not found") { }
    }
}