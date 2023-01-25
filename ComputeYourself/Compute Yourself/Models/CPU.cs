using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Models
{
    public class Cpu : Product, IEntityBase
    {
        [Display(Name = "Socket")]
        [Required(ErrorMessage = "Socket is required")]
        public string Socket { get; set; }

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
    }
}