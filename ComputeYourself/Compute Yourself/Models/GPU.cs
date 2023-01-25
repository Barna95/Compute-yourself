using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Services.Base;

namespace ComputeYourself.Models
{
    public class Gpu : Product, IEntityBase
    {
        [Display(Name = "VideoChipset")]
        [Required(ErrorMessage = "VideoChipset is required")]
        public string VideoChipset { get; set; }

        [Display(Name = "VramSize")]
        [Required(ErrorMessage = "VramSize is required")]
        public int VramSize { get; set; }

        [Display(Name = "VramType")]
        [Required(ErrorMessage = "VramType is required")]
        public string VramType { get; set; }

        [Display(Name = "RequiredPSU")]
        [Required(ErrorMessage = "RequiredPSU is required")]
        public int RequiredPSU { get; set; }

        [Display(Name = "Length")]
        [Required(ErrorMessage = "Length is required")]
        public int Length { get; set; }
    }
}