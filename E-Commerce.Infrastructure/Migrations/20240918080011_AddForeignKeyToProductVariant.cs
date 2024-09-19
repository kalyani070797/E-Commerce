using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToProductVariant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_ProductVariantMasterId",
                table: "ProductVariant",
                column: "ProductVariantMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariant_ProductVariantMaster_ProductVariantMasterId",
                table: "ProductVariant",
                column: "ProductVariantMasterId",
                principalTable: "ProductVariantMaster",
                principalColumn: "ProductVariantMasterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariant_ProductVariantMaster_ProductVariantMasterId",
                table: "ProductVariant");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariant_ProductVariantMasterId",
                table: "ProductVariant");
        }
    }
}
