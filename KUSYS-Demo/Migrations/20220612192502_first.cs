using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KUSYS_Demo.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[,]
                {
                    { "CSI101", "Introduction to Computer Science" },
                    { "CSI102", "Algorithms" },
                    { "MAT101", "Calculus" },
                    { "PHY101", "Physics" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthDate", "CourseId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 12, 22, 25, 2, 24, DateTimeKind.Local).AddTicks(6852), "CSI101", "Ramazan", "Bayazit" },
                    { 2, new DateTime(2022, 6, 12, 22, 25, 2, 24, DateTimeKind.Local).AddTicks(6861), "CSI102", "Rıdvan", "Abay" },
                    { 3, new DateTime(2022, 6, 12, 22, 25, 2, 24, DateTimeKind.Local).AddTicks(6863), "MAT101", "Mert", "Artan" },
                    { 4, new DateTime(2022, 6, 12, 22, 25, 2, 24, DateTimeKind.Local).AddTicks(6864), "PHY101", "Recep", "Çil" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
