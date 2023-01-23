using ComputeYourself.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ComputeYourself.Models
{
    public abstract class Product
    {
        public int Id { get; set; }

        [Display(Name = "Cpu name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]

        [Column(TypeName = "decimal(18, 6)")]
        public decimal Price { get; set; }

        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Brand is required")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }
    }
}
