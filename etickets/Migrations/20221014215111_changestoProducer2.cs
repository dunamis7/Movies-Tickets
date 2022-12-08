using Microsoft.EntityFrameworkCore.Migrations;

namespace etickets.Migrations
{
    public partial class changestoProducer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Producers",
                newName: "ProducerID");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "ProducerID");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                newName: "IX_Movies_ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies",
                column: "ProducerID",
                principalTable: "Producers",
                principalColumn: "ProducerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Producers",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
