using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComputeYourself.Migrations
{
    /// <inheritdoc />
    public partial class ReworkProductproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Medias");

            migrationBuilder.AlterColumn<string>(
                name: "MemoryType",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "Rams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Psus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "Psus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "Psus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "Psus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "PcCases",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "PcCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "PcCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "PcCases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RAM",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Chipset",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "MotherBoards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "VramType",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VideoChipset",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "Gpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ConnectionType",
                table: "Drives",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Drives",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "Drives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "Drives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "Drives",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Socket",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "Cpus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CpuType",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CoolerType",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "mainImage",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "modelNumber",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "productOfficialWebsite",
                table: "CpuCoolers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "Psus");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "Psus");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "Psus");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "PcCases");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "MotherBoards");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "Gpus");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "Drives");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "Drives");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "Drives");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "mainImage",
                table: "CpuCoolers");

            migrationBuilder.DropColumn(
                name: "modelNumber",
                table: "CpuCoolers");

            migrationBuilder.DropColumn(
                name: "productOfficialWebsite",
                table: "CpuCoolers");

            migrationBuilder.AlterColumn<int>(
                name: "MemoryType",
                table: "Rams",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Rams",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Psus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "PcCases",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Socket",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RAM",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Chipset",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "VramType",
                table: "Gpus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "VideoChipset",
                table: "Gpus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Gpus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ConnectionType",
                table: "Drives",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Drives",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Socket",
                table: "Cpus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "Cpus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CpuType",
                table: "CpuCoolers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CoolerType",
                table: "CpuCoolers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Brand",
                table: "CpuCoolers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
