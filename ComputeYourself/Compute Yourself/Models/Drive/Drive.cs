using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.Drive;

namespace ComputeYourself.Models.Drive
{
    public class Drive : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "Drive Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Display(Name = "Connection type")]
        [Required(ErrorMessage = "ConnectionType is required")]
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