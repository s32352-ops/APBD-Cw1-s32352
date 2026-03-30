using System;
using EquipmentRental.Models;
using EquipmentRental.Services;

namespace EquipmentRental
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IEquipmentService equipmentService = new EquipmentService();
            IUserService userService = new UserService();
            IRentalService rentalService = new RentalService(equipmentService);  
            var student = new Student("Jan", "Kowalski");
            var employee = new Employee("Ewa", "Nowak");
            var laptop = new Laptop("super gaming", "Dell", 512);
            var projector = new Projector("Epson", 3000, "4K");
            var camera = new Camera("Canon", 24, true);
            userService.AddUser(student);
            userService.AddUser(employee);
            equipmentService.AddEquipment(laptop);
            equipmentService.AddEquipment(projector);
            equipmentService.AddEquipment(camera);
            
            
            rentalService.Rent(student, laptop.Id, 2);
            try
            {
                rentalService.Rent(student, laptop.Id, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            rentalService.Return(laptop.Id,DateTime.Now);
            rentalService.Rent(employee, camera.Id, 2);
            rentalService.Return(camera.Id, DateTime.Now.AddDays(3));
            rentalService.Rent(employee, camera.Id, 2);
            rentalService.PrintReport();
            
            
            
        }
    }
}