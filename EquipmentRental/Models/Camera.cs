namespace EquipmentRental.Models
{
    public class Camera:Equipment
    {
        public int Megapixels { get; set; }
        public bool IsWaterProof { get; set; }

        public Camera(string name, int megapixels, bool isWaterProof) : base(name)
        {
            Megapixels = megapixels;
            IsWaterProof = isWaterProof;
        }
    }
}