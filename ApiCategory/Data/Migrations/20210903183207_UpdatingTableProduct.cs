using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UpdatingTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Category_CategoryId",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoryId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Produto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Produto",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoryId",
                table: "Produto",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Category_CategoryId",
                table: "Produto",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
