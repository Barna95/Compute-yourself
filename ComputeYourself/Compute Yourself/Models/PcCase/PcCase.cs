using ComputeYourself.Data.Enums;
using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums.MotherBoard;
using System.Text.Json.Serialization;

namespace ComputeYourself.Models.PcCase
{
    public class PcCase : Product, IEntityBase
    {
        [Display(Name = "Size")]
        [Required(ErrorMessage = "Size is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SizeStandard SizeCompatibility { get; set; }

        [Display(Name = "Cpu Cooler Height")]
        [Required(ErrorMessage = "MaxCpuCoolerHeight is required")]
        public int MaxCpuCoolerHeight { get; set; }

        [Display(Name = "Gpu length")]
        [Required(ErrorMessage = "MaxGpuLength is required")]
        public int MaxGpuLength { get; set; }

        //Relationships
        public List<PcCase_Media>? PcCaseMedias { get; set; }
    }
}