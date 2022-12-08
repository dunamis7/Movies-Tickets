using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class changestoMovieId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "MovieID");
        }
    }
}
