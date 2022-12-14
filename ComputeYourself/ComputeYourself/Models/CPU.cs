using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.CPU;
using Microsoft.EntityFrameworkCore;

namespace ComputeYourself.Models
{
    public class CPU
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
        public CpuType Socket { get; set; }
        // public CpuFamilyType CpuFamily { get; set; }
        public bool ManufacturerCooler { get; set; }

        // in MB
        public int L3Cache { get; set; }
        public int TotalCache { get; set; }

        public int Cores { get; set; }
        public int Threads { get; set; }

        // Integrated graphical unit
        public string Igpu { get; set; }
        public int TDP { get; set; }

        // in Ghz
        public float CoreClock { get; set; }
        public float TurboCoreClock { get; set; }
    }
}
