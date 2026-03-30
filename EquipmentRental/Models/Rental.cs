using System;

namespace EquipmentRental.Models
{
    public class Rental
    {
        private static int _idCounter = 1;
        public const int PenaltyPerDay = 5;
        public int Id { get;set; }
        public User User { get;set; }
        public Equipment Equipment { get; set; }
        public DateTime RentedAt { get;set; }
        public DateTime? ReturnedAt { get; set; }
        public DateTime DueDate { get; set; }
        public decimal? Penalty { get; set; }
        
        public bool IsReturned => ReturnedAt != null;
        public bool IsOverdue => !IsReturned && DateTime.Now > DueDate;
        
        public Rental(User user, Equipment equipment, int days)
        {
            Id = _idCounter++;
            User = user;
            Equipment = equipment;
            RentedAt = DateTime.Now;
            DueDate = RentedAt.AddDays(days);
        }
        public void Return(DateTime returnDate){
            ReturnedAt = returnDate;
            if (returnDate > DueDate)
            {
                int daysLate = (returnDate - DueDate).Days;
                Penalty = daysLate * PenaltyPerDay;
            }
        }
    }
}