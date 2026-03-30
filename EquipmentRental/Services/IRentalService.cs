using System.Collections.Generic;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public interface IRentalService
    {
        void Rent(User user, int equipmentId, int days);
        void Return(int equipmentId);
        List<Rental> GetActiveByUser(int userId);
        List<Rental> GetOverdue();
        List<Rental> GetAll();
        void PrintReport();
    }       
}