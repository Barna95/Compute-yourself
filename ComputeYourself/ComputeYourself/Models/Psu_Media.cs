namespace ComputeYourself.Models
{
    public class Psu_Media
    {
        public int PsuId { get; set; }
        public PSU Psu { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
