using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.GPU;

namespace ComputeYourself.Models.GPU
{
    public class Gpu : Product, IEntityBase
    {
        [Display(Name = "VideoChipset")]
        [Required(ErrorMessage = "VideoChipset is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VideoChipsets VideoChipset { get; set; }

        [Display(Name = "VramSize")]
        [Required(ErrorMessage = "VramSize is required")]
        public int VramSize { get; set; }

        [Display(Name = "VramType")]
        [Required(ErrorMessage = "VramType is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public VramTypes VramType { get; set; }

        [Display(Name = "RequiredPSU")]
        [Required(ErrorMessage = "RequiredPSU is required")]
        public int RequiredPSU { get; set; }

        [Display(Name = "Length")]
        [Required(ErrorMessage = "Length is required")]
        public int Length { get; set; }

        //Relationships
        public List<Gpu_Media>? Gpu_Medias { get; set; }
    }
}