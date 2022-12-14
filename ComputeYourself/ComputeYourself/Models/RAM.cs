using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;
namespace ComputeYourself.Models
{
    public class RAM
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
        public int Size { get; set; }
        public MemoryCompatibility MemoryType { get; set; }
        public int Frequency { get; set; }
        public int Latency { get; set; }
        public bool HeatSink { get; set; }
    }
}