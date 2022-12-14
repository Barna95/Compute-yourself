using System.ComponentModel.DataAnnotations;

namespace ComputeYourself.Models
{
    public class PcCase : BaseModel
    {
        [Key] 
        public int Id { get; set; }
        public int SizeCompatibility { get; set; }
        public int MaxCpuCoolerHeight { get; set; }
        public int MaxGpuLength { get; set; }
    }
}