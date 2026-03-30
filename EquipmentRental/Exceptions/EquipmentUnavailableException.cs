using System;

namespace EquipmentRental.Exceptions
{
    public class EquipmentUnavailableException : Exception
    {
        public EquipmentUnavailableException(): base("Equipment is not available") { }
    }
}