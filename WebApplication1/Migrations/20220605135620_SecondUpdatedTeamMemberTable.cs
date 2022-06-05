using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SecondUpdatedTeamMemberTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamMemberPositionId",
                table: "Teams",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_TeamMemberPositionId",
                table: "Teams",
                column: "TeamMemberPositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Positions_TeamMemberPositionId",
                table: "Teams",
                column: "TeamMemberPositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Positions_TeamMemberPositionId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_TeamMemberPositionId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamMemberPositionId",
                table: "Teams");
        }
    }
}
