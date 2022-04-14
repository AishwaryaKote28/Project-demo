using Microsoft.EntityFrameworkCore.Migrations;

namespace InstituteManagementSystem.Migrations.DataBase
{
    public partial class CreateReletionshipChangedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "StudentAdmissionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "StudentAdmissionDetails");
        }
    }
}
