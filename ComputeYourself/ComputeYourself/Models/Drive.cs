using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Enums.Drive;

namespace ComputeYourself.Models
{
    public class Drive : BaseModel
    {
        [Key] 
        public int Id { get; set; }
        //public InstallationTypes InstallationType { get; set; }
        //public DriveSizes DriveSize { get; set; }
        public ConnectionTypes ConnectionType { get; set; }
        public int Capacity { get; set; }
        public int MaxWrite { get; set; }
        public int MaxRead { get; set; }
    }
}