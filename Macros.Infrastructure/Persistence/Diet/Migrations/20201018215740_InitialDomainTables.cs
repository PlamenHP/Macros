using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Macros.Infrastructure.Persistence.Diet.Migrations
{
    public partial class InitialDomainTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumedFoodLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumedFoodLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutrients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    ConsumptionTime = table.Column<DateTime>(nullable: false),
                    ConsumedFoodListId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutrients_ConsumedFoodLists_ConsumedFoodListId",
                        column: x => x.ConsumedFoodListId,
                        principalTable: "ConsumedFoodLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Nutrients_ConsumedFoodListId",
                table: "Nutrients",
                column: "ConsumedFoodListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrients");

            migrationBuilder.DropTable(
                name: "ConsumedFoodLists");
        }
    }
}
