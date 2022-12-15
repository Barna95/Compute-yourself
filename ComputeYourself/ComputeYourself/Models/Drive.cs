using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.Drive;

namespace ComputeYourself.Models
{
    public class Drive : IEntityBase
    {
        [Key] 
        public int Id { get; set; }
        //public InstallationTypes InstallationType { get; set; }
        //public DriveSizes DriveSize { get; set; }
        [Display(Name = "Drive name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Drive Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Drive Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }
        [Display(Name = "Drive Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }
        [Display(Name = "Drive Warranty")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }
        [Display(Name = "Drive Rating")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }
        [Display(Name = "Drive ConnectionType")]
        [Required(ErrorMessage = "ConnectionType is required")]
        public ConnectionTypes ConnectionType { get; set; }
        [Display(Name = "Drive Capacity")]
        [Required(ErrorMessage = "Capacity is required")]
        public int Capacity { get; set; }
        [Display(Name = "Drive MaxWrite")]
        [Required(ErrorMessage = "MaxWrite is required")]
        public int MaxWrite { get; set; }
        [Display(Name = "Drive MaxRead")]
        [Required(ErrorMessage = "MaxRead is required")]
        public int MaxRead { get; set; }

        //Relationships
        public List<Drive_Media>? Drive_Medias { get; set; }
    }
}