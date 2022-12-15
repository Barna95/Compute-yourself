using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.CPU;
using ComputeYourself.Data.Enums.CpuCooler;

namespace ComputeYourself.Models
{
    public class CpuCooler : IEntityBase
    {
        public int Id { get; set; }
        [Display(Name = "Cpu cooler name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Cpu cooler Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Cpu cooler Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Display(Name = "Cpu cooler Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }
        [Display(Name = "Cpu cooler Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }
        [Display(Name = "Cpu cooler Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }
        [Display(Name = "Cpu cooler CoolerType")]
        [Required(ErrorMessage = "Size is required")]
        public CoolerTypes CoolerType { get; set; }
        [Display(Name = "Cpu cooler Height")]
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }
        [Display(Name = "Cpu cooler CpuType")]
        [Required(ErrorMessage = "CpuType is required")]
        public CpuType CpuType { get; set; }

        //Relationships
        public List<CpuCooler_Media>? CpuCooler_Medias { get; set; }
    }
}