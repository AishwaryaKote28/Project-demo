using Microsoft.EntityFrameworkCore.Migrations;

namespace InstituteManagementSystem.Migrations.DataBase
{
    public partial class CreateReletionshipsChangedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetails_StudentAdmissionDetails_StudentId",
                table: "CourseDetails");

            migrationBuilder.DropIndex(
                name: "IX_CourseDetails_StudentId",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "CourseDetails");

            migrationBuilder.AddColumn<int>(
                name: "CourseDetailsCourseId",
                table: "StudentAdmissionDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentAdmissionDetails_CourseDetailsCourseId",
                table: "StudentAdmissionDetails",
                column: "CourseDetailsCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAdmissionDetails_CourseDetails_CourseDetailsCourseId",
                table: "StudentAdmissionDetails",
                column: "CourseDetailsCourseId",
                principalTable: "CourseDetails",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAdmissionDetails_CourseDetails_CourseDetailsCourseId",
                table: "StudentAdmissionDetails");

            migrationBuilder.DropIndex(
                name: "IX_StudentAdmissionDetails_CourseDetailsCourseId",
                table: "StudentAdmissionDetails");

            migrationBuilder.DropColumn(
                name: "CourseDetailsCourseId",
                table: "StudentAdmissionDetails");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "CourseDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetails_StudentId",
                table: "CourseDetails",
                column: "StudentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetails_StudentAdmissionDetails_StudentId",
                table: "CourseDetails",
                column: "StudentId",
                principalTable: "StudentAdmissionDetails",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
