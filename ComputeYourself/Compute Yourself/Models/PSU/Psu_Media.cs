namespace ComputeYourself.Models.PSU
{
    public class Psu_Media
    {
        public int PsuId { get; set; }
        public Psu Psu { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}