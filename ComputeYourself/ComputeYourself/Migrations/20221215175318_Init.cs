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
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
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
                    LANPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "CpuCoolerMedias",
                columns: table => new
                {
                    CpuCoolerId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuCoolerMedias", x => new { x.CpuCoolerId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_CpuCoolerMedias_CpuCoolers_CpuCoolerId",
                        column: x => x.CpuCoolerId,
                        principalTable: "CpuCoolers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CpuCoolerMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CpuMedias",
                columns: table => new
                {
                    CpuId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuMedias", x => new { x.CpuId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_CpuMedias_Cpus_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CpuMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriveMedias",
                columns: table => new
                {
                    DriveId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveMedias", x => new { x.DriveId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_DriveMedias_Drives_DriveId",
                        column: x => x.DriveId,
                        principalTable: "Drives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriveMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GpuMedias",
                columns: table => new
                {
                    GpuId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpuMedias", x => new { x.GpuId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_GpuMedias_Gpus_GpuId",
                        column: x => x.GpuId,
                        principalTable: "Gpus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GpuMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoardMedias",
                columns: table => new
                {
                    MotherBoardId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoardMedias", x => new { x.MotherBoardId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_MotherBoardMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotherBoardMedias_MotherBoards_MotherBoardId",
                        column: x => x.MotherBoardId,
                        principalTable: "MotherBoards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PcCaseMedias",
                columns: table => new
                {
                    PcCaseId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PcCaseMedias", x => new { x.PcCaseId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_PcCaseMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PcCaseMedias_PcCases_PcCaseId",
                        column: x => x.PcCaseId,
                        principalTable: "PcCases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PsuMedias",
                columns: table => new
                {
                    PsuId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PsuMedias", x => new { x.PsuId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_PsuMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PsuMedias_Psus_PsuId",
                        column: x => x.PsuId,
                        principalTable: "Psus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RamMedias",
                columns: table => new
                {
                    RamId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RamMedias", x => new { x.RamId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_RamMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RamMedias_Rams_RamId",
                        column: x => x.RamId,
                        principalTable: "Rams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CpuCoolerMedias_MediaId",
                table: "CpuCoolerMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_CpuMedias_MediaId",
                table: "CpuMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_DriveMedias_MediaId",
                table: "DriveMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_GpuMedias_MediaId",
                table: "GpuMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoardMedias_MediaId",
                table: "MotherBoardMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_PcCaseMedias_MediaId",
                table: "PcCaseMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_PsuMedias_MediaId",
                table: "PsuMedias",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_RamMedias_MediaId",
                table: "RamMedias",
                column: "MediaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CpuCoolerMedias");

            migrationBuilder.DropTable(
                name: "CpuMedias");

            migrationBuilder.DropTable(
                name: "DriveMedias");

            migrationBuilder.DropTable(
                name: "GpuMedias");

            migrationBuilder.DropTable(
                name: "MotherBoardMedias");

            migrationBuilder.DropTable(
                name: "PcCaseMedias");

            migrationBuilder.DropTable(
                name: "PsuMedias");

            migrationBuilder.DropTable(
                name: "RamMedias");

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
                name: "Medias");

            migrationBuilder.DropTable(
                name: "Rams");
        }
    }
}
