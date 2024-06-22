using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalApiProject.Migrations
{
    public partial class InitialCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "GraduateTrainees",
                columns: table => new
                {
                    GraduateTraineeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeId = table.Column<int>(type: "int", nullable: false),
                    GraduateTraineeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduateTraineeEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLastSemesterPending = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfApplication = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AI = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Python = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BusinessAnalysis = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MachineLearning = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Practical = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalMarks = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Percentages = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsAdmissionConfirmed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduateTrainees", x => x.GraduateTraineeId);
                    table.ForeignKey(
                        name: "FK_GraduateTrainees_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GraduateTrainees_DegreeId",
                table: "GraduateTrainees",
                column: "DegreeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GraduateTrainees");

            migrationBuilder.DropTable(
                name: "Degrees");
        }
    }
}
