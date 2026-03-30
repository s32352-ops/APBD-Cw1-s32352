using System;

namespace EquipmentRental.Exceptions
{
    public class RentalLimitException:Exception
    {
        public RentalLimitException() : base("User exceeded rental limit") { }
    }
}