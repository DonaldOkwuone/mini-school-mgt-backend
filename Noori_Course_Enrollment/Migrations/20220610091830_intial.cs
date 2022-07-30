using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noori_Course_Enrollment.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "noori_levels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noori_levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "noori_schools",
                columns: table => new
                {
                    Noori_SchoolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ViceChancellor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noori_schools", x => x.Noori_SchoolID);
                });

            migrationBuilder.CreateTable(
                name: "noori_departments",
                columns: table => new
                {
                    Noori_DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Noori_SchoolID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noori_departments", x => x.Noori_DepartmentID);
                    table.ForeignKey(
                        name: "FK_noori_departments_noori_schools_Noori_SchoolID",
                        column: x => x.Noori_SchoolID,
                        principalTable: "noori_schools",
                        principalColumn: "Noori_SchoolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "noori_courses",
                columns: table => new
                {
                    Noori_CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseProfessor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Noori_DepartmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noori_courses", x => x.Noori_CourseID);
                    table.ForeignKey(
                        name: "FK_noori_courses_noori_departments_Noori_DepartmentID",
                        column: x => x.Noori_DepartmentID,
                        principalTable: "noori_departments",
                        principalColumn: "Noori_DepartmentID");
                });

            migrationBuilder.CreateTable(
                name: "noori_students",
                columns: table => new
                {
                    Noori_StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Noori_DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noori_students", x => x.Noori_StudentID);
                    table.ForeignKey(
                        name: "FK_noori_students_noori_departments_Noori_DepartmentID",
                        column: x => x.Noori_DepartmentID,
                        principalTable: "noori_departments",
                        principalColumn: "Noori_DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Noori_Student_Registrations",
                columns: table => new
                {
                    Noori_Student_RegistrationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Noori_CourseID = table.Column<int>(type: "int", nullable: false),
                    Noori_StudentID = table.Column<int>(type: "int", nullable: false),
                    Noori_Level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noori_Student_Registrations", x => x.Noori_Student_RegistrationID);
                    table.ForeignKey(
                        name: "FK_Noori_Student_Registrations_noori_courses_Noori_CourseID",
                        column: x => x.Noori_CourseID,
                        principalTable: "noori_courses",
                        principalColumn: "Noori_CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Noori_Student_Registrations_noori_students_Noori_StudentID",
                        column: x => x.Noori_StudentID,
                        principalTable: "noori_students",
                        principalColumn: "Noori_StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_noori_courses_Noori_DepartmentID",
                table: "noori_courses",
                column: "Noori_DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_noori_departments_Noori_SchoolID",
                table: "noori_departments",
                column: "Noori_SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Noori_Student_Registrations_Noori_CourseID",
                table: "Noori_Student_Registrations",
                column: "Noori_CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Noori_Student_Registrations_Noori_StudentID",
                table: "Noori_Student_Registrations",
                column: "Noori_StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_noori_students_Noori_DepartmentID",
                table: "noori_students",
                column: "Noori_DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "noori_levels");

            migrationBuilder.DropTable(
                name: "Noori_Student_Registrations");

            migrationBuilder.DropTable(
                name: "noori_courses");

            migrationBuilder.DropTable(
                name: "noori_students");

            migrationBuilder.DropTable(
                name: "noori_departments");

            migrationBuilder.DropTable(
                name: "noori_schools");
        }
    }
}
