using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models.RAM
{
    public class RAM : IEntityBase
    {
        public int Id { get; set; }

        [Display(Name = "RAM name")]
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

        [Display(Name = "Size")]
        [Required(ErrorMessage = "Size is required")]
        public int Size { get; set; }

        [Display(Name = "MemoryType")]
        [Required(ErrorMessage = "MemoryType is required")]
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