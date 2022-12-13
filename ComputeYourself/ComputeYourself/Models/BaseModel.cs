using ComputeYourself.Data.Enums;

namespace ComputeYourself.Models
{
    public class BaseModel
    {
        public IEnumerable<string> Media { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
    }
}
