using ComputeYourself.Data.Enums.CPU;

namespace ComputeYourself.Models
{
    public class CpuCooler : BaseModel
    {
        public int Id { get; set; }
        public CoolerTypes CoolerType { get; set; }
        public int Height { get; set; }
        public CpuType CpuType { get; set; }
    }
}