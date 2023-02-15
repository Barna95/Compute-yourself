using System.ComponentModel.DataAnnotations;
using API.Data.Services.Base;

namespace API.Models;

public class Ram : Product, IEntityBase
{
    [Display(Name = "Size")]
    [Required(ErrorMessage = "Size is required")]
    public int Size { get; set; }

    [Display(Name = "MemoryType")]
    [Required(ErrorMessage = "MemoryType is required")]
    public string MemoryType { get; set; }

    [Display(Name = "Frequency")]
    [Required(ErrorMessage = "Frequency is required")]
    public int Frequency { get; set; }

    [Display(Name = "Latency")]
    [Required(ErrorMessage = "Latency is required")]
    public int Latency { get; set; }

    [Display(Name = "HeatSink")]
    [Required(ErrorMessage = "HeatSink is required")]
    public bool HeatSink { get; set; }
}