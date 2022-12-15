namespace ComputeYourself.Models
{
    public class Gpu_Media
    {
        public int GpuId { get; set; }
        public GPU Gpu { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
