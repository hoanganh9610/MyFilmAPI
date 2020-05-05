using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFilm.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(nullable: true),
                    FilmImage = table.Column<string>(nullable: true),
                    FilmTypeId = table.Column<int>(nullable: false),
                    Episode = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: true),
                    FilmRate = table.Column<int>(nullable: false),
                    Story = table.Column<string>(nullable: true),
                    FilmStatus = table.Column<string>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
