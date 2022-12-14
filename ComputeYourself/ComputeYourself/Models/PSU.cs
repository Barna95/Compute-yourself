using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.PSU;

namespace ComputeYourself.Models
{
    public class PSU
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool? Modular { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public Classification? Classification { get; set; }
    }
}