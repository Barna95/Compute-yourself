using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.PSU;

namespace ComputeYourself.Models.PSU
{
    public class Psu : Product,IEntityBase
    {
        [Display(Name = "Capacity")]
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }

        [Display(Name = "Modular")]
        [Required(ErrorMessage = "Modular is required")]
        public bool? Modular { get; set; }

        [Display(Name = "Classification")]
        [Required(ErrorMessage = "Classification is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Classification? Classification { get; set; }

        //Relationships
        public List<Psu_Media>? Psu_Medias { get; set; }
    }
}