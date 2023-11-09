using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreatBakery.Migrations
{
    public partial class ModelUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treats_Flavors_FlavorId",
                table: "Treats");

            migrationBuilder.DropIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "FlavorId",
                table: "Treats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlavorId",
                table: "Treats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treats_FlavorId",
                table: "Treats",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Treats_Flavors_FlavorId",
                table: "Treats",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId");
        }
    }
}
