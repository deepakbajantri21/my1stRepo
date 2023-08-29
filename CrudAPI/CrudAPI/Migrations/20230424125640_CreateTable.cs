using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_DOB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Age = table.Column<int>(type: "int", nullable: false),
                    Employee_Salary = table.Column<float>(type: "real", nullable: false),
                    Employee_Dept = table.Column<int>(type: "int", nullable: false),
                    Employee_EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Employee_Image_URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeData");
        }
    }
}
