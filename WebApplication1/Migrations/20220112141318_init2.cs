using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Department_dep_id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrauctor_Courses_crs_id",
                table: "Instrauctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_dep_id",
                table: "Course",
                newName: "IX_Course_dep_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dep_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trainee_Department_dep_id",
                        column: x => x.dep_id,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courseResult",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    crs_id = table.Column<int>(type: "int", nullable: true),
                    train_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseResult", x => x.ID);
                    table.ForeignKey(
                        name: "FK_courseResult_Course_crs_id",
                        column: x => x.crs_id,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_courseResult_Trainee_train_id",
                        column: x => x.train_id,
                        principalTable: "Trainee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courseResult_crs_id",
                table: "courseResult",
                column: "crs_id");

            migrationBuilder.CreateIndex(
                name: "IX_courseResult_train_id",
                table: "courseResult",
                column: "train_id");

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_dep_id",
                table: "Trainee",
                column: "dep_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Department_dep_id",
                table: "Course",
                column: "dep_id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrauctor_Course_crs_id",
                table: "Instrauctor",
                column: "crs_id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Department_dep_id",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Instrauctor_Course_crs_id",
                table: "Instrauctor");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "courseResult");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Course_dep_id",
                table: "Courses",
                newName: "IX_Courses_dep_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Department_dep_id",
                table: "Courses",
                column: "dep_id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instrauctor_Courses_crs_id",
                table: "Instrauctor",
                column: "crs_id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
