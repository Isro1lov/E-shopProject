using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace E_shop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TagTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cart_items_carts_cart_id",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "fk_product_category_categories_category_id",
                table: "product_category");

            migrationBuilder.DropForeignKey(
                name: "fk_product_category_products_product_id",
                table: "product_category");

            migrationBuilder.DropIndex(
                name: "ix_cart_items_cart_id",
                table: "cart_items");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_category",
                table: "product_category");

            migrationBuilder.DropIndex(
                name: "ix_product_category_product_id",
                table: "product_category");

            migrationBuilder.RenameTable(
                name: "product_category",
                newName: "product_categories");

            migrationBuilder.RenameIndex(
                name: "ix_product_category_category_id",
                table: "product_categories",
                newName: "ix_product_categories_category_id");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<decimal>(
                name: "regular_price",
                table: "products",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "categories",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                table: "categories",
                type: "boolean",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "product_categories",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories",
                columns: new[] { "product_id", "category_id" });

            migrationBuilder.CreateTable(
                name: "tag",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tag_name = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tag", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_tag",
                columns: table => new
                {
                    tag_id = table.Column<int>(type: "integer", nullable: false),
                    product_id = table.Column<int>(type: "integer", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product_tag", x => new { x.product_id, x.tag_id });
                    table.ForeignKey(
                        name: "fk_product_tag_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_product_tag_tag_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tag",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_cart_items_card_id",
                table: "cart_items",
                column: "card_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_tag_tag_id",
                table: "product_tag",
                column: "tag_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cart_items_carts_card_id",
                table: "cart_items",
                column: "card_id",
                principalTable: "carts",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_categories_products_product_id",
                table: "product_categories",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cart_items_carts_card_id",
                table: "cart_items");

            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_categories_category_id",
                table: "product_categories");

            migrationBuilder.DropForeignKey(
                name: "fk_product_categories_products_product_id",
                table: "product_categories");

            migrationBuilder.DropTable(
                name: "product_tag");

            migrationBuilder.DropTable(
                name: "tag");

            migrationBuilder.DropIndex(
                name: "ix_cart_items_card_id",
                table: "cart_items");

            migrationBuilder.DropPrimaryKey(
                name: "pk_product_categories",
                table: "product_categories");

            migrationBuilder.RenameTable(
                name: "product_categories",
                newName: "product_category");

            migrationBuilder.RenameIndex(
                name: "ix_product_categories_category_id",
                table: "product_category",
                newName: "ix_product_category_category_id");

            migrationBuilder.AlterColumn<string>(
                name: "sku",
                table: "products",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<decimal>(
                name: "regular_price",
                table: "products",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "categories",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<bool>(
                name: "active",
                table: "categories",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "product_category",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_product_category",
                table: "product_category",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "ix_cart_items_cart_id",
                table: "cart_items",
                column: "cart_id");

            migrationBuilder.CreateIndex(
                name: "ix_product_category_product_id",
                table: "product_category",
                column: "product_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cart_items_carts_cart_id",
                table: "cart_items",
                column: "cart_id",
                principalTable: "carts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_category_categories_category_id",
                table: "product_category",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_product_category_products_product_id",
                table: "product_category",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
