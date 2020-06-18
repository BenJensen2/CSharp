using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedding_Planner.Migrations
{
    public partial class ContextRSVPDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RSVP_Users_UserId",
                table: "RSVP");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVP_Weddings_WeddingId",
                table: "RSVP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RSVP",
                table: "RSVP");

            migrationBuilder.RenameTable(
                name: "RSVP",
                newName: "RSVPs");

            migrationBuilder.RenameIndex(
                name: "IX_RSVP_WeddingId",
                table: "RSVPs",
                newName: "IX_RSVPs_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_RSVP_UserId",
                table: "RSVPs",
                newName: "IX_RSVPs_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs",
                column: "RSVPId");

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Users_UserId",
                table: "RSVPs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Weddings_WeddingId",
                table: "RSVPs",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Users_UserId",
                table: "RSVPs");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Weddings_WeddingId",
                table: "RSVPs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RSVPs",
                table: "RSVPs");

            migrationBuilder.RenameTable(
                name: "RSVPs",
                newName: "RSVP");

            migrationBuilder.RenameIndex(
                name: "IX_RSVPs_WeddingId",
                table: "RSVP",
                newName: "IX_RSVP_WeddingId");

            migrationBuilder.RenameIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVP",
                newName: "IX_RSVP_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RSVP",
                table: "RSVP",
                column: "RSVPId");

            migrationBuilder.AddForeignKey(
                name: "FK_RSVP_Users_UserId",
                table: "RSVP",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVP_Weddings_WeddingId",
                table: "RSVP",
                column: "WeddingId",
                principalTable: "Weddings",
                principalColumn: "WeddingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
