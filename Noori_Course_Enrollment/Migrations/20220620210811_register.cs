using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noori_Course_Enrollment.Migrations
{
    public partial class register : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "noori_students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "noori_students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "noori_students",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "noori_students");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "noori_students");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "noori_students");
        }
    }
}
