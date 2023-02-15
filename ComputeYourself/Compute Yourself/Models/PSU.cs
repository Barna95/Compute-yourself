using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using API.Data.Enums;
using API.Data.Services.Base;

namespace API.Models;

public class Psu : Product, IEntityBase
{
    [Display(Name = "Capacity")]
    [Required(ErrorMessage = "Capacity is required")]
    public int Capacity { get; set; }

    [Display(Name = "Modular")]
    [Required(ErrorMessage = "Modular is required")]
    public bool? Modular { get; set; }

    [Display(Name = "Classification")]
    [Required(ErrorMessage = "Classification is required")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Classification? Classification { get; set; }
}