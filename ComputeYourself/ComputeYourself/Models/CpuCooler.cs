using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.CPU;
using ComputeYourself.Data.Enums.CpuCooler;

namespace ComputeYourself.Models
{
    public class CpuCooler
    {
        [Key]
        public int Id { get; set; }
        public List<Media> Media { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public CoolerTypes CoolerType { get; set; }
        public int Height { get; set; }
        public CpuType CpuType { get; set; }
    }
}