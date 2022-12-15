using ComputeYourself.Data.Enums;
using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models
{
    public class PcCase : IEntityBase
    {
        [Key] 
        public int Id { get; set; }

        [Display(Name= "Pc case name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Pc case Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Pc case Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "Pc case Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "Pc case Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "Pc case Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Display(Name = "Pc case SizeCompatibility")]
        [Required(ErrorMessage = "Size is required")]
        public SizeStandard SizeCompatibility { get; set; }

        [Display(Name = "Pc case MaxCpuCoolerHeight")]
        [Required(ErrorMessage = "MaxCpuCoolerHeight is required")]
        public int MaxCpuCoolerHeight { get; set; }

        [Display(Name = "Pc case MaxGpuLength")]
        [Required(ErrorMessage = "MaxGpuLength is required")]
        public int MaxGpuLength { get; set; }

        //Relationships
        public List<PcCase_Media>? PcCaseMedias { get; set; }
    }
}