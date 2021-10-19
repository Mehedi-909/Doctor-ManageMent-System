using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePrescription.Migrations
{
    public partial class pp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "disease",
                table: "PatientTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "disease",
                table: "PatientTable");
        }
    }
}
