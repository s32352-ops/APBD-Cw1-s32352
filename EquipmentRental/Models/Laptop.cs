namespace EquipmentRental.Models
{
    public class Laptop:Equipment
    {
        public string Brand { get; set; }
        public int Memory { get; set; }

        public Laptop(string name, string brand, int memory) : base(name)
        {
            Brand = brand;
            Memory = memory;
        }
    }
}