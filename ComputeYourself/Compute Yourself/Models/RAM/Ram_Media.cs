namespace ComputeYourself.Models.RAM
{
    public class Ram_Media
    {
        public int RamId { get; set; }
        public Ram Ram { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}