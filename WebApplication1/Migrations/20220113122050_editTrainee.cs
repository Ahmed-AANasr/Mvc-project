using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class editTrainee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "crs_id",
                table: "Trainee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_crs_id",
                table: "Trainee",
                column: "crs_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainee_Course_crs_id",
                table: "Trainee",
                column: "crs_id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainee_Course_crs_id",
                table: "Trainee");

            migrationBuilder.DropIndex(
                name: "IX_Trainee_crs_id",
                table: "Trainee");

            migrationBuilder.DropColumn(
                name: "crs_id",
                table: "Trainee");
        }
    }
}
