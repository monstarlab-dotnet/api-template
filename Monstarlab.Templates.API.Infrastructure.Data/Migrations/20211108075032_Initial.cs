using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Monstarlab.Templates.API.Infrastructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apartment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Apartment", "City", "Country", "Floor", "Number", "Street", "ZipCode" },
                values: new object[] { new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"), null, "Aarhus", "Denmark", "9", "2F", "Mariane Thomsens Gade", "8000" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Apartment", "City", "Country", "Floor", "Number", "Street", "ZipCode" },
                values: new object[] { new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b"), null, "Copenhagen", "Denmark", null, "4", "Orientkaj", "2150" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[] { new Guid("35607bf7-9a00-489d-bf71-bbdb53f2f7d8"), 29L, new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"), "Morten", "Pløger" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[] { new Guid("efb8f31e-cdd3-4d6b-96a3-3ee6fe9ae679"), 32L, new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"), "Morten", "Turn Pedersen" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "FirstName", "LastName" },
                values: new object[] { new Guid("fa4b4f52-0c8b-4839-bbc1-d33a9bf2ca38"), 31L, new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b"), "Kasper", "Welner" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
