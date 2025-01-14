using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowerCheckout");

            migrationBuilder.AddColumn<int>(
                name: "BorrowerID",
                table: "Checkout",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CheckoutID",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_BorrowerID",
                table: "Checkout",
                column: "BorrowerID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CheckoutID",
                table: "Books",
                column: "CheckoutID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Quantity",
                table: "Books",
                column: "Quantity",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Checkout_CheckoutID",
                table: "Books",
                column: "CheckoutID",
                principalTable: "Checkout",
                principalColumn: "CheckoutID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_Borrowers_BorrowerID",
                table: "Checkout",
                column: "BorrowerID",
                principalTable: "Borrowers",
                principalColumn: "BorrowerID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Checkout_CheckoutID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_Borrowers_BorrowerID",
                table: "Checkout");

            migrationBuilder.DropIndex(
                name: "IX_Checkout_BorrowerID",
                table: "Checkout");

            migrationBuilder.DropIndex(
                name: "IX_Books_CheckoutID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Quantity",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BorrowerID",
                table: "Checkout");

            migrationBuilder.DropColumn(
                name: "CheckoutID",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BorrowerCheckout",
                columns: table => new
                {
                    BorrowersBorrowerID = table.Column<int>(type: "int", nullable: false),
                    CheckoutsCheckoutID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowerCheckout", x => new { x.BorrowersBorrowerID, x.CheckoutsCheckoutID });
                    table.ForeignKey(
                        name: "FK_BorrowerCheckout_Borrowers_BorrowersBorrowerID",
                        column: x => x.BorrowersBorrowerID,
                        principalTable: "Borrowers",
                        principalColumn: "BorrowerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowerCheckout_Checkout_CheckoutsCheckoutID",
                        column: x => x.CheckoutsCheckoutID,
                        principalTable: "Checkout",
                        principalColumn: "CheckoutID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowerCheckout_CheckoutsCheckoutID",
                table: "BorrowerCheckout",
                column: "CheckoutsCheckoutID");
        }
    }
}
