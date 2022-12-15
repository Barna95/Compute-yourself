using System.ComponentModel.DataAnnotations;
using ComputeYourself.Data.Base;
using ComputeYourself.Data.Enums;
using ComputeYourself.Data.Enums.Drive;

namespace ComputeYourself.Models
{
    public class Drive : IEntityBase
    {
        [Key] 
        public int Id { get; set; }
        //public InstallationTypes InstallationType { get; set; }
        //public DriveSizes DriveSize { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ManuFacturerBrand Brand { get; set; }
        public int Warranty { get; set; }
        public float Rating { get; set; }
        public ConnectionTypes ConnectionType { get; set; }
        public int Capacity { get; set; }
        public int MaxWrite { get; set; }
        public int MaxRead { get; set; }

        //Relationships
        public List<Drive_Media>? Drive_Medias { get; set; }
    }
}