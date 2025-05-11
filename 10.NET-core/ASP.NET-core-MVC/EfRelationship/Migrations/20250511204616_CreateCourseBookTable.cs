using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfRelationship.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CourseId",
                table: "Books",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Courses_CourseId",
                table: "Books",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Courses_CourseId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CourseId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Books");
        }
    }
}
