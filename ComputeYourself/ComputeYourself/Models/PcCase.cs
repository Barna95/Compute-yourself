using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.PcCase;

namespace ComputeYourself.Models
{
    public class PcCase : BaseModel
    {
        [Key]
        public SizeCompatibilities SizeCompatibility { get; set; }
        public MaxCPUCoolerHeights MaxCpuCoolerHeight { get; set; }
        public MaxGPULengths MaxGpuLength { get; set; }
    }
}