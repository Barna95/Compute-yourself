using System.ComponentModel.DataAnnotations;
using API.Data.Services.Base;

namespace API.Models;

public class Drive : Product, IEntityBase
{
    [Display(Name = "Connection type")]
    [Required(ErrorMessage = "ConnectionType is required")]
    public string ConnectionType { get; set; }

    [Display(Name = "Capacity")]
    [Required(ErrorMessage = "Capacity is required")]
    public int Capacity { get; set; }

    [Display(Name = "Max write speed")]
    [Required(ErrorMessage = "MaxWrite is required")]
    public int MaxWrite { get; set; }

    [Display(Name = "Max reed speed")]
    [Required(ErrorMessage = "MaxRead is required")]
    public int MaxRead { get; set; }
}