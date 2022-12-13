using System.Net.Sockets;
using ComputeYourself.Data.Enums.CPU;

namespace ComputeYourself.Models
{
    public class CpuCooler : BaseModel
    {
        public int Height { get; set; }
        public CpuType CpuType { get; set; }
    }
}
