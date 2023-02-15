using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using API.Data.Enums;
using API.Data.Services.Base;

namespace API.Models;

public class PcCase : Product, IEntityBase
{
    [Display(Name = "Size")]
    [Required(ErrorMessage = "Size is required")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SizeStandard SizeCompatibility { get; set; }

    [Display(Name = "Cpu Cooler Height")]
    [Required(ErrorMessage = "MaxCpuCoolerHeight is required")]
    public int MaxCpuCoolerHeight { get; set; }

    [Display(Name = "Gpu length")]
    [Required(ErrorMessage = "MaxGpuLength is required")]
    public int MaxGpuLength { get; set; }
}