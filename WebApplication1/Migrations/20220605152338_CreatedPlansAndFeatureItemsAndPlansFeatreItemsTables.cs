using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class CreatedPlansAndFeatureItemsAndPlansFeatreItemsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsFeature = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlansFeatureItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlansId = table.Column<int>(nullable: false),
                    FeatureItemsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansFeatureItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlansFeatureItems_FeatureItems_FeatureItemsId",
                        column: x => x.FeatureItemsId,
                        principalTable: "FeatureItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlansFeatureItems_Plans_PlansId",
                        column: x => x.PlansId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlansFeatureItems_FeatureItemsId",
                table: "PlansFeatureItems",
                column: "FeatureItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_PlansFeatureItems_PlansId",
                table: "PlansFeatureItems",
                column: "PlansId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlansFeatureItems");

            migrationBuilder.DropTable(
                name: "FeatureItems");

            migrationBuilder.DropTable(
                name: "Plans");
        }
    }
}
