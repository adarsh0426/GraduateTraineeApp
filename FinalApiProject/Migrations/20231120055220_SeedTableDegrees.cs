using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalApiProject.Migrations
{
    public partial class SeedTableDegrees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "DegreeId", "DegreeName" },
                values: new object[,]
                {
                { 1, "BCA" },
                { 2, "MCA" },
                { 3, "BTech" },
                { 4, "BE Computer" },
                { 5, "ME Computer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Degrees]", true);
        }
    }
}
