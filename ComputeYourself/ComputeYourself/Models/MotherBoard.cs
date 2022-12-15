using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models
{
    public class MotherBoard : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "MotherBoard Name :")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "MotherBoard Description :")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price :")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "MotherBoard Brand :")]
        [Required(ErrorMessage = "Brand is required")]
        public ManuFacturerBrand Brand { get; set; }

        [Display(Name = "MotherBoard Warranty :")]
        [Required(ErrorMessage = "Warranty is required")]
        public int Warranty { get; set; }

        [Display(Name = "MotherBoard Rating :")]
        [Required(ErrorMessage = "Rating is required")]
        public float Rating { get; set; }

        [Display(Name = "Socket :")]
        [Required(ErrorMessage = "Socket is required")]
        public CpuType Socket { get; set; }

        [Display(Name = "Chipset :")]
        [Required(ErrorMessage = "Chipset is required")]
        public ChipsetType Chipset { get; set; }

        [Display(Name = "Size :")]
        [Required(ErrorMessage = "Size is required")]
        public SizeStandard Size { get; set; }

        [Display(Name = "IGPU :")]
        public string? Igpu { get; set; }

        [Display(Name = "RAM type :")]
        [Required(ErrorMessage = "RAM is required")]
        public MemoryCompatibility RAM { get; set; }

        [Display(Name = "Frequency :")]
        [Required(ErrorMessage = "Frequency is required")]
        public int Frequency { get; set; }

        [Display(Name = "MemorySockets :")]
        [Required(ErrorMessage = "MemorySockets is required")]
        public int MemorySockets { get; set; }

        [Display(Name = "XMP :")]
        [Required(ErrorMessage = "XMP is required")]
        public bool XMP { get; set; }

        [Display(Name = "MaxMemory :")]
        [Required(ErrorMessage = "MaxMemory is required")]
        public int MaxMemory { get; set; }

        [Display(Name = "CForSLISupport :")]
        public string? CForSLISupport { get; set; }

        [Display(Name = "Bluetooth :")]
        public string? Bluetooth { get; set; }

        [Display(Name = "Lighting :")]
        [Required(ErrorMessage = "Lighting is required")]
        public bool Lighting { get; set; }

        [Display(Name = "Windows11Support :")]
        [Required(ErrorMessage = "Windows11Support is required")]
        public bool Windows11Support { get; set; }

        [Display(Name = "Wifi :")]
        public string? Wifi { get; set; }

        [Display(Name = "LANPort :")]
        [Required(ErrorMessage = "LANPort is required")]
        public string LANPort { get; set; }

        [Display(Name = "LanportsNumber :")]
        [Required(ErrorMessage = "LanportsNumber is required")]
        public int LanportsNumber { get; set; }
        // Connectivity

        [Display(Name = "PCIe16x :")]
        [Required(ErrorMessage = "PCIe16x is required")]
        public int PCIe16x { get; set; }

        [Display(Name = "SATA3 :")]
        [Required(ErrorMessage = "SATA3 is required")]
        public int SATA3 { get; set; }

        [Display(Name = "M2 :")]
        [Required(ErrorMessage = "M2 is required")]
        public int M2 { get; set; }

        [Display(Name = "USB2 :")]
        [Required(ErrorMessage = "USB2 is required")]
        public int USB2 { get; set; }

        [Display(Name = "USB3 :")]
        [Required(ErrorMessage = "USB3 is required")]
        public int USB3 { get; set; }

        [Display(Name = "USB3.1 :")]
        [Required(ErrorMessage = "USB31 is required")]
        public int USB31 { get; set; }

        [Display(Name = "USBC :")]
        [Required(ErrorMessage = "USBC is required")]
        public int USBC { get; set; }

        //Relationships
        public List<MotherBoard_Media>? MotherBoard_Medias { get; set; }
    }
}
