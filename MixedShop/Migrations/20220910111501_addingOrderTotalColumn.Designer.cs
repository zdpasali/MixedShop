﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MixedShop.Models;

namespace MixedShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220910111501_addingOrderTotalColumn")]
    partial class addingOrderTotalColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MixedShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Phone",
                            Description = "opis"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Keyboard",
                            Description = "opis"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Mouse",
                            Description = "opis"
                        });
                });

            modelBuilder.Entity("MixedShop.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRecommended")
                        .HasColumnType("bit");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CategoryId = 1,
                            Description = "testni podaci",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "prvi item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 2,
                            CategoryId = 2,
                            Description = "testni podaci2",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = true,
                            Make = "make2",
                            Name = "drugi item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 3,
                            CategoryId = 3,
                            Description = "testni podaci3",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "prvi item",
                            Price = 110m
                        },
                        new
                        {
                            ItemId = 4,
                            CategoryId = 2,
                            Description = "testni podaci24",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make2",
                            Name = "drugi item",
                            Price = 310m
                        },
                        new
                        {
                            ItemId = 5,
                            CategoryId = 1,
                            Description = "testni podaci",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "5 item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 6,
                            CategoryId = 3,
                            Description = "testni podaci2",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = true,
                            Make = "make2",
                            Name = "7 item",
                            Price = 120m
                        },
                        new
                        {
                            ItemId = 7,
                            CategoryId = 3,
                            Description = "testni podaci3",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "8 item",
                            Price = 110m
                        },
                        new
                        {
                            ItemId = 8,
                            CategoryId = 1,
                            Description = "testni podaci24",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make2",
                            Name = "9 item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 9,
                            CategoryId = 1,
                            Description = "testni podaci",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "prvi item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 10,
                            CategoryId = 2,
                            Description = "testni podaci2",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make2",
                            Name = "drugi item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 11,
                            CategoryId = 3,
                            Description = "testni podaci3",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = true,
                            Make = "make1",
                            Name = "prvi item",
                            Price = 110m
                        },
                        new
                        {
                            ItemId = 12,
                            CategoryId = 2,
                            Description = "testni podaci24",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make2",
                            Name = "drugi item",
                            Price = 310m
                        },
                        new
                        {
                            ItemId = 13,
                            CategoryId = 1,
                            Description = "testni podaci",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "5 item",
                            Price = 10m
                        },
                        new
                        {
                            ItemId = 14,
                            CategoryId = 3,
                            Description = "testni podaci2",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = true,
                            Make = "make2",
                            Name = "7 item",
                            Price = 120m
                        },
                        new
                        {
                            ItemId = 15,
                            CategoryId = 3,
                            Description = "testni podaci3",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make1",
                            Name = "8 item",
                            Price = 110m
                        },
                        new
                        {
                            ItemId = 16,
                            CategoryId = 1,
                            Description = "testni podaci24",
                            ImageThumbnailUrl = "",
                            ImageUrl = "",
                            IsRecommended = false,
                            Make = "make2",
                            Name = "9 item",
                            Price = 10m
                        });
                });

            modelBuilder.Entity("MixedShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MixedShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("ItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("MixedShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("ShoppingCartItem");
                });

            modelBuilder.Entity("MixedShop.Models.Item", b =>
                {
                    b.HasOne("MixedShop.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MixedShop.Models.OrderDetail", b =>
                {
                    b.HasOne("MixedShop.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MixedShop.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MixedShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("MixedShop.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MixedShop.Models.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("MixedShop.Models.Order", b =>
                {
                    b.Navigation("OrderLines");
                });
#pragma warning restore 612, 618
        }
    }
}
