using Microsoft.EntityFrameworkCore.Migrations;

namespace Wedding_Planner.Migrations
{
    public partial class WeddingUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_PlannerUserId",
                table: "Weddings");

            migrationBuilder.DropIndex(
                name: "IX_Weddings_PlannerUserId",
                table: "Weddings");

            migrationBuilder.DropColumn(
                name: "PlannerUserId",
                table: "Weddings");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Weddings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_UserId",
                table: "Weddings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weddings_Users_UserId",
                table: "Weddings");

            migrationBuilder.DropIndex(
                name: "IX_Weddings_UserId",
                table: "Weddings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Weddings");

            migrationBuilder.AddColumn<int>(
                name: "PlannerUserId",
                table: "Weddings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_PlannerUserId",
                table: "Weddings",
                column: "PlannerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weddings_Users_PlannerUserId",
                table: "Weddings",
                column: "PlannerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
