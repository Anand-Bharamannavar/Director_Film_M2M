using Microsoft.EntityFrameworkCore.Migrations;

namespace Many2Many.Migrations
{
    public partial class codefirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AwardCount = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorName);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    Collection = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmName);
                });

            migrationBuilder.CreateTable(
                name: "FilmDirectors",
                columns: table => new
                {
                    FilmName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DirectorName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmDirectors", x => new { x.FilmName, x.DirectorName });
                    table.ForeignKey(
                        name: "FK_FilmDirectors_Directors_DirectorName",
                        column: x => x.DirectorName,
                        principalTable: "Directors",
                        principalColumn: "DirectorName",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmDirectors_Films_FilmName",
                        column: x => x.FilmName,
                        principalTable: "Films",
                        principalColumn: "FilmName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmDirectors_DirectorName",
                table: "FilmDirectors",
                column: "DirectorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmDirectors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
