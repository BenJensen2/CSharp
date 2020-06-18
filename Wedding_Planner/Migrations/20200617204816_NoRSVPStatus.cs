using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedding_Planner.Migrations
{
    public partial class NoRSVPStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Users_UserId",
                table: "RSVPs");

            migrationBuilder.DropIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Users_UserId",
                table: "RSVPs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
