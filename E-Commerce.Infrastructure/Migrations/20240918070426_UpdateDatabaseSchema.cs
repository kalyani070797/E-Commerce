using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_User_UserId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Customer_UserId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Review",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "Stock_Quantity",
                table: "Product",
                newName: "StockQuantity");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Product",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "Payment_Method",
                table: "Payment",
                newName: "PaymentMethod");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Payment",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "Created_At",
                table: "Order",
                newName: "CreatedOn");

            migrationBuilder.AddColumn<decimal>(
                name: "ActualPrice",
                table: "Inventory",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountPrice",
                table: "Inventory",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductVariantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantMasterId = table.Column<int>(type: "int", nullable: false),
                    VariantName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => x.ProductVariantId);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariantMaster",
                columns: table => new
                {
                    ProductVariantMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariantMaster", x => x.ProductVariantMasterId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_ProductVariantId",
                table: "Inventory",
                column: "ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_ProductVariant_ProductVariantId",
                table: "Inventory",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "ProductVariantId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_ProductVariant_ProductVariantId",
                table: "Inventory");

            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DropTable(
                name: "ProductVariantMaster");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_ProductVariantId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ActualPrice",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "DiscountPrice",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ProductVariantId",
                table: "Inventory");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Review",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Product",
                newName: "Stock_Quantity");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Product",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "PaymentMethod",
                table: "Payment",
                newName: "Payment_Method");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Payment",
                newName: "Created_At");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Order",
                newName: "Created_At");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserId",
                table: "Customer",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_User_UserId",
                table: "Customer",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
