using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.GPU;

namespace ComputeYourself.Models
{
    public class GPU : BaseModel
    {
        [Key] 
        public int Id { get; set; }
        public VideoChipsets VideoChipset { get; set; }
        public int VramSize { get; set; }
        public VramTypes VramType { get; set; }
        public int RequiredPSU { get; set; }
        public int Length { get; set; }
    }
}
