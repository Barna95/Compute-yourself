using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.MotherBoard;
namespace ComputeYourself.Models
{
    public class RAM : BaseModel
    {
        [Key] 
        public int Id { get; set; }
        public int Size { get; set; }
        public MemoryCompatibility MemoryType { get; set; }
        public int Frequency { get; set; }
        public int Latency { get; set; }
        public bool HeatSink { get; set; }
    }
}