using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.PSU;

namespace ComputeYourself.Models
{
    public class PSU : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Psu capacity")]
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }
        [Display(Name = "Psu modular")]
        [Required(ErrorMessage = "Modular is required")]
        public bool? Modular { get; set; }
        [Display(Name = "Psu name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Psu Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Psu Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Display(Name = "Psu Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }
        [Display(Name = "Psu Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }
        [Display(Name = "Psu Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }
        [Display(Name = "Psu Classification")]
        [Required(ErrorMessage = "Classification is required")]
        public Classification? Classification { get; set; }

        //Relationships
        public List<Psu_Media>? Psu_Medias { get; set; }
    }
}