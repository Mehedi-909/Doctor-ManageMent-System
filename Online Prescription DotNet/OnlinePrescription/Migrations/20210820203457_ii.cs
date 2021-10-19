using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePrescription.Migrations
{
    public partial class ii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorAuthTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAuthTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorInfoTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorInfoTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MedicineTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    indication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PatientTable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorAuthTable");

            migrationBuilder.DropTable(
                name: "DoctorInfoTable");

            migrationBuilder.DropTable(
                name: "MedicineTable");

            migrationBuilder.DropTable(
                name: "PatientTable");
        }
    }
}
