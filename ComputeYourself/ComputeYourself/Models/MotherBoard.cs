using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.MotherBoard;

namespace ComputeYourself.Models
{
    public class MotherBoard
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public CpuType Socket { get; set; }
        public ChipsetType Chipset { get; set; }
        public SizeStandard Size { get; set; }
        public string? Igpu { get; set; }
        public MemoryCompatibility RAM { get; set; }
        public int Frequency { get; set; }
        public int MemorySockets { get; set; }
        public bool XMP { get; set; }
        public int MaxMemory { get; set; }
        public string? CForSLISupport { get; set; }
        public string? Bluetooth { get; set; }
        public bool Lighting { get; set; }
        public bool Windows11Support { get; set; }
        public string? Wifi { get; set; }
        public string LANPort { get; set; }
        public int LanportsNumber { get; set; }
        // Connectivity
        public int PCIe16x { get; set; }
        public int SATA3 { get; set; }
        public int M2 { get; set; }
        public int USB2 { get; set; }
        public int USB3 { get; set; }
        public int USB31 { get; set; }
        public int USBC { get; set; }
    }
}
