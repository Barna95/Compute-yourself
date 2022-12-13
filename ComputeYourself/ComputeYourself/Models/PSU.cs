using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.PSU;

namespace ComputeYourself.Models
{
    public class PSU : BaseModel
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool? Modular { get; set; }
        public Classification? Classification { get; set; }
    }
}