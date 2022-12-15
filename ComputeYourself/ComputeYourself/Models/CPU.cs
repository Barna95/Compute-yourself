using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.CPU;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ComputeYourself.Models
{
    public class CPU : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "CPU name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "CPU Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "CPU Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "CPU Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "CPU Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "CPU Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Display(Name = "CPU Socket")]
        [Required(ErrorMessage = "Socket is required")]
        public CpuType Socket { get; set; }
        // public CpuFamilyType CpuFamily { get; set; }

        [Display(Name = "CPU ManufacturerCooler")]
        [Required(ErrorMessage = "ManufacturerCooler is required")]
        public bool ManufacturerCooler { get; set; }

        [Display(Name = "CPU L3Cache")]
        [Required(ErrorMessage = "L3Cache is required")]
        public int L3Cache { get; set; }

        [Display(Name = "CPU TotalCache")]
        [Required(ErrorMessage = "TotalCache is required")]
        public int TotalCache { get; set; }

        [Display(Name = "CPU Cores")]
        [Required(ErrorMessage = "Cores is required")]
        public int Cores { get; set; }

        [Display(Name = "CPU Threads")]
        [Required(ErrorMessage = "Threads is required")]
        public int Threads { get; set; }

        [Display(Name = "CPU Igpu")]
        [Required(ErrorMessage = "Igpu is required")]
        public string Igpu { get; set; }

        [Display(Name = "CPU TDP")]
        [Required(ErrorMessage = "TDP is required")]
        public int TDP { get; set; }
        

        [Display(Name = "CPU CoreClock")]
        [Required(ErrorMessage = "CoreClock is required")]
        public float CoreClock { get; set; }

        [Display(Name = "CPU TurboCoreClock")]
        [Required(ErrorMessage = "TurboCoreClock is required")]
        public float TurboCoreClock { get; set; }

        //Relationships
        public List<Cpu_Media>? Cpu_Medias { get; set; }
    }
}
