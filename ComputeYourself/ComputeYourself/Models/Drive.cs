using System.ComponentModel.DataAnnotations;

namespace ComputeYourself.Models
{
    public abstract class Drive
    {
        [Key] public int Id { get; set; }
        public InstallationTypes InstallationType { get; set; }
        public DriveSizes DriveSize { get; set; }
        public ConnectionTypes ConnectionType { get; set; }
        public int Capacity { get; set; }
        public int MaxWrite { get; set; }
        public int MaxRead { get; set; }
    }
}