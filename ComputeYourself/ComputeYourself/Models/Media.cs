using System.ComponentModel.DataAnnotations;

namespace ComputeYourself.Models
{
    public class Media
    {
        [Key]
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
