using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePrescription.Migrations
{
    public partial class p3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescribedMedicine",
                table: "PrescribedMedicine");

            migrationBuilder.AlterColumn<string>(
                name: "medicineName",
                table: "PrescribedMedicine",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "PrescribedMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescribedMedicine",
                table: "PrescribedMedicine",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescribedMedicine",
                table: "PrescribedMedicine");

            migrationBuilder.DropColumn(
                name: "id",
                table: "PrescribedMedicine");

            migrationBuilder.AlterColumn<string>(
                name: "medicineName",
                table: "PrescribedMedicine",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescribedMedicine",
                table: "PrescribedMedicine",
                column: "medicineName");
        }
    }
}
