using ComputeYourself.Data.Enums.PSU;

namespace ComputeYourself.Models
{
    public class PSU : BaseModel
    {
        public int Capacity { get; set; }
        public bool? Modular { get; set; }
        public Classification? Classification { get; set; }
    }
}