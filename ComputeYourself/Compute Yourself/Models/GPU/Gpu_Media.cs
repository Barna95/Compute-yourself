namespace ComputeYourself.Models.GPU
{
    public class Gpu_Media
    {
        public int GpuId { get; set; }
        public Gpu Gpu { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}