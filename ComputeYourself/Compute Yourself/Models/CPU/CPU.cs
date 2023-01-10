using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models.CPU
{
    public class CPU : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "CPU name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Display(Name = "Socket")]
        [Required(ErrorMessage = "Socket is required")]
        public CpuType Socket { get; set; }

        [Display(Name = "ManufacturerCooler")]
        [Required(ErrorMessage = "ManufacturerCooler is required")]
        public bool ManufacturerCooler { get; set; }

        [Display(Name = "L3Cache")]
        [Required(ErrorMessage = "L3Cache is required")]
        public int L3Cache { get; set; }

        [Display(Name = "TotalCache")]
        [Required(ErrorMessage = "TotalCache is required")]
        public int TotalCache { get; set; }

        [Display(Name = "Cores")]
        [Required(ErrorMessage = "Cores is required")]
        public int Cores { get; set; }

        [Display(Name = "Threads")]
        [Required(ErrorMessage = "Threads is required")]
        public int Threads { get; set; }

        [Display(Name = "iGPU")]
        [Required(ErrorMessage = "Igpu is required")]
        public string Igpu { get; set; }

        [Display(Name = "TDP")]
        [Required(ErrorMessage = "TDP is required")]
        public int TDP { get; set; }

        [Display(Name = "Core Clock")]
        [Required(ErrorMessage = "CoreClock is required")]
        public float CoreClock { get; set; }

        [Display(Name = "Turbo Core Clock")]
        [Required(ErrorMessage = "TurboCoreClock is required")]
        public float TurboCoreClock { get; set; }

        //Relationships
        public List<Cpu_Media>? Cpu_Medias { get; set; }
    }
}