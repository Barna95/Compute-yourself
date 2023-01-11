namespace ComputeYourself.Models.CPU
{
    public class Cpu_Media
    {
        public int CpuId { get; set; }
        public Cpu Cpu { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}