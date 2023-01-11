using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.CpuCooler;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models.CpuCooler
{
    public class CpuCooler : Product,IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "CoolerType")]
        [Required(ErrorMessage = "Size is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CoolerTypes CoolerType { get; set; }

        [Display(Name = "Height")]
        [Required(ErrorMessage = "Height is required")]
        public int Height { get; set; }

        [Display(Name = "CpuType")]
        [Required(ErrorMessage = "CpuType is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CpuType CpuType { get; set; }

        //Relationships
        public List<CpuCooler_Media>? CpuCooler_Medias { get; set; }
    }
}