using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using API.Data.Enums;
using API.Data.Services.Base;

namespace API.Models;

public class MotherBoard : Product, IEntityBase
{
    [Display(Name = "Socket")]
    [Required(ErrorMessage = "Socket is required")]
    public string Socket { get; set; }

    [Display(Name = "Chipset")]
    [Required(ErrorMessage = "Chipset is required")]
    public string Chipset { get; set; }

    [Display(Name = "Size")]
    [Required(ErrorMessage = "Size is required")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SizeStandard Size { get; set; }

    [Display(Name = "iGPU")] public string? Igpu { get; set; }

    [Display(Name = "Ram")]
    [Required(ErrorMessage = "Ram is required")]
    public string RAM { get; set; }

    [Display(Name = "Frequency")]
    [Required(ErrorMessage = "Frequency is required")]
    public int Frequency { get; set; }

    [Display(Name = "MemorySockets")]
    [Required(ErrorMessage = "MemorySockets is required")]
    public int MemorySockets { get; set; }

    [Display(Name = "XMP")]
    [Required(ErrorMessage = "XMP is required")]
    public bool XMP { get; set; }

    [Display(Name = "MaxMemory")]
    [Required(ErrorMessage = "MaxMemory is required")]
    public int MaxMemory { get; set; }

    [Display(Name = "CForSLISupport")] public string? CForSLISupport { get; set; }

    [Display(Name = "Bluetooth")] public string? Bluetooth { get; set; }

    [Display(Name = "Lighting")]
    [Required(ErrorMessage = "Lighting is required")]
    public bool Lighting { get; set; }

    [Display(Name = "Windows11Support")]
    [Required(ErrorMessage = "Windows11Support is required")]
    public bool Windows11Support { get; set; }

    [Display(Name = "Wifi")] public string? Wifi { get; set; }

    [Display(Name = "LANPort")]
    [Required(ErrorMessage = "LANPort is required")]
    public string LANPort { get; set; }

    [Display(Name = "LAN-ports")]
    [Required(ErrorMessage = "LanportsNumber is required")]
    public int LanportsNumber { get; set; }

    [Display(Name = "PCIe16x")]
    [Required(ErrorMessage = "PCIe16x is required")]
    public int PCIe16x { get; set; }

    [Display(Name = "SATA3")]
    [Required(ErrorMessage = "SATA3 is required")]
    public int SATA3 { get; set; }

    [Display(Name = "M2")]
    [Required(ErrorMessage = "M2 is required")]
    public int M2 { get; set; }

    [Display(Name = "USB2")]
    [Required(ErrorMessage = "USB2 is required")]
    public int USB2 { get; set; }

    [Display(Name = "USB3")]
    [Required(ErrorMessage = "USB3 is required")]
    public int USB3 { get; set; }

    [Display(Name = "USB3.1")]
    [Required(ErrorMessage = "USB31 is required")]
    public int USB31 { get; set; }

    [Display(Name = "USBC")]
    [Required(ErrorMessage = "USBC is required")]
    public int USBC { get; set; }
}