using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Models
{
    public class CpuCooler : Product, IEntityBase
    {
        [Display(Name = "CoolerType")]
        [Required(ErrorMessage = "Size is required")]
        public string CoolerType { get; set; }

        [Display(Name = "Height")]
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }

        [Display(Name = "CpuType")]
        [Required(ErrorMessage = "CpuType is required")]
        public string CpuType { get; set; }
    }
}