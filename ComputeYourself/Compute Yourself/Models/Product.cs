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
        public string Brand { get; set; }

        [Display(Name = "Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Required(ErrorMessage = "Main Image is required")]
        public string mainImage { get; set; }

        [Required(ErrorMessage = "Product official-website is required")]
        public string productOfficialWebsite { get; set; }

        [Required(ErrorMessage = "Serial number is required")]
        public string modelNumber { get; set; }

    }
}
