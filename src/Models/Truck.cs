namespace TruckManager.src.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int YearManufacture  { get; set; }
        public int ModelYear  { get; set; }
        public DateTime CreatedAt {  get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}