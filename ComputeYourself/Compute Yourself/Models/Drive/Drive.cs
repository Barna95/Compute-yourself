using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.Drive;

namespace ComputeYourself.Models.Drive
{
    public class Drive : Product, IEntityBase
    {
        [Display(Name = "Connection type")]
        [Required(ErrorMessage = "ConnectionType is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ConnectionTypes ConnectionType { get; set; }

        [Display(Name = "Capacity")]
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }

        [Display(Name = "Max write speed")]
        [Required(ErrorMessage = "MaxWrite is required")]
        public int MaxWrite { get; set; }

        [Display(Name = "Max reed speed")]
        [Required(ErrorMessage = "MaxRead is required")]
        public int MaxRead { get; set; }

        //Relationships
        public List<Drive_Media>? Drive_Medias { get; set; }
    }
}