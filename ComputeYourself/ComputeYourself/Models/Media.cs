using ComputeYourself.Models.CPU;
using ComputeYourself.Models.CpuCooler;
using ComputeYourself.Models.Drive;
using ComputeYourself.Models.GPU;
using ComputeYourself.Models.MotherBoard;
using ComputeYourself.Models.PcCase;
using ComputeYourself.Models.PSU;
using ComputeYourself.Models.RAM;

namespace ComputeYourself.Models
{
    public class Media
    {
        public int Id { get; set; }
        public string MediaURL { get; set; }

        //Relationship
        public List<Cpu_Media>? Cpu_Medias { get; set; }
        public List<CpuCooler_Media>? CpuCooler_Medias { get; set; }
        public List<Drive_Media>? Drive_Medias { get; set; }
        public List<Gpu_Media>? Gpu_Medias { get; set; }
        public List<MotherBoard_Media>? MotherBoard_Medias { get; set; }
        public List<PcCase_Media>? PcCaseMedias { get; set; }
        public List<Psu_Media>? Psu_Medias { get; set; }
        public List<Ram_Media>? Ram_Medias { get; set; }
    }
}