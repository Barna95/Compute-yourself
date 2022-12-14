using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputeYourself.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CpuCoolers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    CoolerType = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    CpuType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuCoolers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Socket = table.Column<int>(type: "int", nullable: false),
                    ManufacturerCooler = table.Column<bool>(type: "bit", nullable: false),
                    L3Cache = table.Column<int>(type: "int", nullable: false),
                    TotalCache = table.Column<int>(type: "int", nullable: false),
                    Cores = table.Column<int>(type: "int", nullable: false),
                    Threads = table.Column<int>(type: "int", nullable: false),
                    Igpu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TDP = table.Column<int>(type: "int", nullable: false),
                    CoreClock = table.Column<float>(type: "real", nullable: false),
                    TurboCoreClock = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    ConnectionType = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    MaxWrite = table.Column<int>(type: "int", nullable: false),
                    MaxRead = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    VideoChipset = table.Column<int>(type: "int", nullable: false),
                    VramSize = table.Column<int>(type: "int", nullable: false),
                    VramType = table.Column<int>(type: "int", nullable: false),
                    RequiredPSU = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Socket = table.Column<int>(type: "int", nullable: false),
                    Chipset = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Igpu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    MemorySockets = table.Column<int>(type: "int", nullable: false),
                    XMP = table.Column<bool>(type: "bit", nullable: false),
                    MaxMemory = table.Column<int>(type: "int", nullable: false),
                    CForSLISupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bluetooth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lighting = table.Column<bool>(type: "bit", nullable: false),
                    Windows11Support = table.Column<bool>(type: "bit", nullable: false),
                    Wifi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LANPort = table.Column<float>(type: "real", nullable: false),
                    LanportsNumber = table.Column<int>(type: "int", nullable: false),
                    PCIe16x = table.Column<int>(type: "int", nullable: false),
                    SATA3 = table.Column<int>(type: "int", nullable: false),
                    M2 = table.Column<int>(type: "int", nullable: false),
                    USB2 = table.Column<int>(type: "int", nullable: false),
                    USB3 = table.Column<int>(type: "int", nullable: false),
                    USB31 = table.Column<int>(type: "int", nullable: false),
                    USBC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PcCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    SizeCompatibility = table.Column<int>(type: "int", nullable: false),
                    MaxCpuCoolerHeight = table.Column<int>(type: "int", nullable: false),
                    MaxGpuLength = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Psus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Modular = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Classification = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Brand = table.Column<int>(type: "int", nullable: false),
                    Warranty = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    MemoryType = table.Column<int>(type: "int", nullable: false),
                    Frequency = table.Column<int>(type: "int", nullable: false),
                    Latency = table.Column<int>(type: "int", nullable: false),
                    HeatSink = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUId = table.Column<int>(type: "int", nullable: true),
                    CpuCoolerId = table.Column<int>(type: "int", nullable: true),
                    DriveId = table.Column<int>(type: "int", nullable: true),
                    GPUId = table.Column<int>(type: "int", nullable: true),
                    MotherBoardId = table.Column<int>(type: "int", nullable: true),
                    PSUId = table.Column<int>(type: "int", nullable: true),
                    PcCaseId = table.Column<int>(type: "int", nullable: true),
                    RAMId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_CpuCoolers_CpuCoolerId",
                        column: x => x.CpuCoolerId,
                        principalTable: "CpuCoolers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Cpus_CPUId",
                        column: x => x.CPUId,
                        principalTable: "Cpus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Drives_DriveId",
                        column: x => x.DriveId,
                        principalTable: "Drives",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Gpus_GPUId",
                        column: x => x.GPUId,
                        principalTable: "Gpus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_MotherBoards_MotherBoardId",
                        column: x => x.MotherBoardId,
                        principalTable: "MotherBoards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_PcCases_PcCaseId",
                        column: x => x.PcCaseId,
                        principalTable: "PcCases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Psus_PSUId",
                        column: x => x.PSUId,
                        principalTable: "Psus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Media_Rams_RAMId",
                        column: x => x.RAMId,
                        principalTable: "Rams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_CpuCoolerId",
                table: "Media",
                column: "CpuCoolerId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_CPUId",
                table: "Media",
                column: "CPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_DriveId",
                table: "Media",
                column: "DriveId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_GPUId",
                table: "Media",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_MotherBoardId",
                table: "Media",
                column: "MotherBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_PcCaseId",
                table: "Media",
                column: "PcCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_PSUId",
                table: "Media",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_RAMId",
                table: "Media",
                column: "RAMId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "CpuCoolers");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Drives");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropTable(
                name: "MotherBoards");

            migrationBuilder.DropTable(
                name: "PcCases");

            migrationBuilder.DropTable(
                name: "Psus");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
