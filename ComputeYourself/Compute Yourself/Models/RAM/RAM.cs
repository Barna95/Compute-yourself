using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models.RAM
{
    public class Ram : Product, IEntityBase
    {
        [Display(Name = "Size")]
        [Required(ErrorMessage = "Size is required")]
        public int Size { get; set; }

        [Display(Name = "MemoryType")]
        [Required(ErrorMessage = "MemoryType is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MemoryCompatibility MemoryType { get; set; }

        [Display(Name = "Frequency")]
        [Required(ErrorMessage = "Frequency is required")]
        public int Frequency { get; set; }

        [Display(Name = "Latency")]
        [Required(ErrorMessage = "Latency is required")]
        public int Latency { get; set; }

        [Display(Name = "HeatSink")]
        [Required(ErrorMessage = "HeatSink is required")]
        public bool HeatSink { get; set; }

        //Relationships
        public List<Ram_Media>? Ram_Medias { get; set; }
    }
}