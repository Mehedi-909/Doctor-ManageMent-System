using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePrescription.Migrations
{
    public partial class p1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrescriptionTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    doctorId = table.Column<int>(type: "int", nullable: false),
                    patientId = table.Column<int>(type: "int", nullable: false),
                    dateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    suggestion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PrescribedMedicine",
                columns: table => new
                {
                    medicineName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    morning = table.Column<bool>(type: "bit", nullable: false),
                    noon = table.Column<bool>(type: "bit", nullable: false),
                    night = table.Column<bool>(type: "bit", nullable: false),
                    beforeEating = table.Column<bool>(type: "bit", nullable: false),
                    afterEating = table.Column<bool>(type: "bit", nullable: false),
                    otherInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberOfDaysToTake = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prescriptionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescribedMedicine", x => x.medicineName);
                    table.ForeignKey(
                        name: "FK_PrescribedMedicine_PrescriptionTable_Prescriptionid",
                        column: x => x.Prescriptionid,
                        principalTable: "PrescriptionTable",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrescribedMedicine_Prescriptionid",
                table: "PrescribedMedicine",
                column: "Prescriptionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrescribedMedicine");

            migrationBuilder.DropTable(
                name: "PrescriptionTable");
        }
    }
}
