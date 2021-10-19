using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePrescription.Migrations
{
    public partial class testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicine_PrescriptionTable_Prescriptionid",
                table: "PrescribedMedicine");

            migrationBuilder.AlterColumn<int>(
                name: "Prescriptionid",
                table: "PrescribedMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicine_PrescriptionTable_Prescriptionid",
                table: "PrescribedMedicine",
                column: "Prescriptionid",
                principalTable: "PrescriptionTable",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicine_PrescriptionTable_Prescriptionid",
                table: "PrescribedMedicine");

            migrationBuilder.AlterColumn<int>(
                name: "Prescriptionid",
                table: "PrescribedMedicine",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicine_PrescriptionTable_Prescriptionid",
                table: "PrescribedMedicine",
                column: "Prescriptionid",
                principalTable: "PrescriptionTable",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
