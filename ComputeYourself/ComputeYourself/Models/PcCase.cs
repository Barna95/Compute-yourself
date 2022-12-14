using ComputeYourself.Data.Enums;
using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models
{
    public class PcCase
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public SizeStandard SizeCompatibility { get; set; }
        public int MaxCpuCoolerHeight { get; set; }
        public int MaxGpuLength { get; set; }

        //Relationships
        public List<PcCase_Media>? PcCaseMedias { get; set; }
    }
}