using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TM470GradeCalc.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TM470Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TMA1 = table.Column<double>(type: "float", nullable: false),
                    TMA2 = table.Column<double>(type: "float", nullable: false),
                    TMA3 = table.Column<double>(type: "float", nullable: false),
                    EMA = table.Column<double>(type: "float", nullable: false),
                    CalculationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM470Grades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TM470Grades");
        }
    }
}
