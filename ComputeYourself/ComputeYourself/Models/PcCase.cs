using System.ComponentModel.DataAnnotations;

namespace ComputeYourself.Models
{
    public class PcCase : BaseModel
    {
        [Key]
        public SizeCompatibility SizeCompatibility { get; set; }
        public MaxCPUCoolerHeight MaxCpuCoolerHeight { get; set; }
        public MaxGPULength MaxGpuLength { get; set; }
    }
}