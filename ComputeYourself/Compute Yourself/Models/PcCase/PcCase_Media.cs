namespace ComputeYourself.Models.PcCase
{
    public class PcCase_Media
    {
        public int PcCaseId { get; set; }
        public PcCase PcCase { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}