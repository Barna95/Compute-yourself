using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.GPU;

namespace ComputeYourself.Models
{
    public class GPU
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public VideoChipsets VideoChipset { get; set; }
        public int VramSize { get; set; }
        public VramTypes VramType { get; set; }
        public int RequiredPSU { get; set; }
        public int Length { get; set; }
    }
}
