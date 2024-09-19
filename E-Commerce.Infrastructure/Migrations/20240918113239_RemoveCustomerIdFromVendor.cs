using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCustomerIdFromVendor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendor_Customer_CustomerId",
                table: "Vendor");

            migrationBuilder.DropIndex(
                name: "IX_Vendor_CustomerId",
                table: "Vendor");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Vendor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Vendor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendor_CustomerId",
                table: "Vendor",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendor_Customer_CustomerId",
                table: "Vendor",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
