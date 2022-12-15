namespace ComputeYourself.Models
{
    public class Drive_Media
    {
        public int DriveId { get; set; }
        public Drive Drive { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
