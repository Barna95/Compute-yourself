namespace ComputeYourself.Models
{
    public class MotherBoard_Media
    {
        public int MotherBoardId { get; set; }
        public MotherBoard MotherBoard { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
