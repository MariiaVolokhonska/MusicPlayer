using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer.Migrations
{
    public partial class DBv05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Favourites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserID",
                table: "Favourites",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Favourites_Users_UserID",
                table: "Favourites",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favourites_Users_UserID",
                table: "Favourites");

            migrationBuilder.DropIndex(
                name: "IX_Favourites_UserID",
                table: "Favourites");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Favourites");
        }
    }
}
