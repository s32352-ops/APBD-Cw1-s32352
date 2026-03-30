using System;
using System.Collections.Generic;
using System.Linq;
using EquipmentRental.Enums;
using EquipmentRental.Exceptions;
using EquipmentRental.Models;

namespace EquipmentRental.Services
{
    public class RentalService : IRentalService
    {
        private readonly List<Rental> _rentals = new List<Rental>();
        private readonly IEquipmentService _equipmentService;

        public RentalService(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        public void Rent(User user, int equipmentId, int days)
        {
            var equipment = _equipmentService.GetById(equipmentId);
            if (equipment.Status != EquipmentStatus.Available)
                throw new EquipmentUnavailableException();
            int activeRentals = _rentals.Count(r => r.User.Id == user.Id && !r.IsReturned);
            if (activeRentals >= user.MaxRentals)
                throw new RentalLimitException();

            var rental = new Rental(user, equipment, days);
            _rentals.Add(rental);

            equipment.Status = EquipmentStatus.Rented;
        }

        public void Return(int equipmentId, DateTime returnedAt)
        {
            var rental = _rentals.FirstOrDefault(r => r.Equipment.Id == equipmentId && !r.IsReturned);
            if (rental == null)
                throw new RentalNotFoundException();

            rental.Return(returnedAt);

            var equipment = _equipmentService.GetById(equipmentId);
            equipment.Status = EquipmentStatus.Available;

            Console.WriteLine($"Penalty: {rental.Penalty ?? 0}");
        }

        public List<Rental> GetActiveByUser(int userId) => _rentals.Where(r => r.User.Id == userId && !r.IsReturned).ToList();

        public List<Rental> GetOverdue() => _rentals.Where(r => r.IsOverdue).ToList();

        public List<Rental> GetAll() => _rentals;
        
        public void PrintReport()
        {
            Console.WriteLine("---Rental Report---");
            Console.WriteLine($"Equipment: {_equipmentService.GetAll().Count}");
            Console.WriteLine($"Available: {_equipmentService.GetAvailable().Count}");
            Console.WriteLine($"Active: {_rentals.Count(r => !r.IsReturned)}");
            Console.WriteLine($"Overdue: {GetOverdue().Count}");
            
        }
    }
    
}