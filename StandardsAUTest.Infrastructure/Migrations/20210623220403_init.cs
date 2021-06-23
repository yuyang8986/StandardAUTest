using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StandardsAUTest.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Occupation = table.Column<int>(nullable: false),
                    SumOfValue = table.Column<double>(nullable: false),
                    MonthlyExpensesTotal = table.Column<double>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Age", "DateOfBirth", "MonthlyExpensesTotal", "Name", "Occupation", "PostCode", "State", "SumOfValue" },
                values: new object[] { 1, 30, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100.0, "Test", 2, "2000", "NSW", 1000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
