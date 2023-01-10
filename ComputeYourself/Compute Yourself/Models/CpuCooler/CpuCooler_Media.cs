namespace ComputeYourself.Models.CpuCooler
{
    public class CpuCooler_Media
    {
        public int CpuCoolerId { get; set; }
        public CpuCooler Cpucooler { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}