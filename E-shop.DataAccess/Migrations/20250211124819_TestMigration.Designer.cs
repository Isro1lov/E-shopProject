﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using e_shop.DataAccess;

#nullable disable

namespace E_shop.DataAccess.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20250211124819_TestMigration")]
    partial class TestMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_description");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("icon");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_path");

                    b.Property<int>("ParentId")
                        .HasColumnType("integer")
                        .HasColumnName("parent_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_categories");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("pk_carts");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_carts_customer_id");

                    b.ToTable("carts", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CardId")
                        .HasColumnType("integer")
                        .HasColumnName("card_id");

                    b.Property<int>("CartId")
                        .HasColumnType("integer")
                        .HasColumnName("cart_id");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.HasKey("Id")
                        .HasName("pk_cart_items");

                    b.HasIndex("CartId")
                        .HasDatabaseName("ix_cart_items_cart_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_cart_items_product_id");

                    b.ToTable("cart_items", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("registered_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_customers");

                    b.ToTable("customers", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address_line1");

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address_line2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("country");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<string>("DialCode")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("dial_code");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("phone_number");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("postal_code");

                    b.HasKey("Id")
                        .HasName("pk_customer_address");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_customer_address_customer_id");

                    b.ToTable("customer_address", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("discount_price");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_description");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_name");

                    b.Property<string>("ProductNote")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("product_note");

                    b.Property<decimal>("ProductWeight")
                        .HasColumnType("numeric")
                        .HasColumnName("product_weight");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean")
                        .HasColumnName("published");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<decimal>("RegularPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("regular_price");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sku");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("short_description");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("pk_product_category");

                    b.HasIndex("CategoryId")
                        .HasDatabaseName("ix_product_category_category_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_product_category_product_id");

                    b.ToTable("product_category", (string)null);
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.Cart", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Customer.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_carts_customers_customer_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.CartItem", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Customer.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_items_carts_cart_id");

                    b.HasOne("e_shop.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_cart_items_products_product_id");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.CustomerAddress", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Customer.Customer", "Customer")
                        .WithMany("CustomerAddress")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_address_customers_customer_id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("e_shop.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_category_categories_category_id");

                    b.HasOne("e_shop.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_category_products_product_id");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Customer.Customer", b =>
                {
                    b.Navigation("CustomerAddress");
                });

            modelBuilder.Entity("e_shop.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
