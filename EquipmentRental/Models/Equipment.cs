using EquipmentRental.Enums;

namespace EquipmentRental.Models

{
    public abstract class Equipment
    {
        private static int _idCounter = 1;

        public int Id { get; private set; }
        public string Name { get; set; }
        public EquipmentStatus Status { get; set; }
        
        protected Equipment(string name)
        {
            Id = _idCounter++;
            Name = name;
            Status = EquipmentStatus.Available;
        }
        public override string ToString() => $"{Id} {Name} - {Status}";
    }
    
}