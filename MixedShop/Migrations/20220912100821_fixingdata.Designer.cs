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
    [Migration("20220912100821_fixingdata")]
    partial class fixingdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

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
                            CategoryName = "Monitor",
                            Description = ""
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Keyboard",
                            Description = ""
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Mouse",
                            Description = ""
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Headphone",
                            Description = ""
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Printer",
                            Description = ""
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
                            CategoryId = 4,
                            Description = "Black, Noise Cancelling",
                            ImageThumbnailUrl = "\\Images\\Catalog\\jblheadset.jpg",
                            ImageUrl = "\\Images\\Catalog\\jblheadset.jpg",
                            IsRecommended = true,
                            Make = "JBL",
                            Name = "JBL Headset",
                            Price = 499.99m
                        },
                        new
                        {
                            ItemId = 2,
                            CategoryId = 5,
                            Description = "Wireless, Color All-in-One",
                            ImageThumbnailUrl = "\\Images\\Catalog\\canonprinter.jpg",
                            ImageUrl = "\\Images\\Catalog\\canonprinter.jpg",
                            IsRecommended = false,
                            Make = "Canon",
                            Name = "Canon Printer",
                            Price = 2199.99m
                        },
                        new
                        {
                            ItemId = 3,
                            CategoryId = 3,
                            Description = "Wireless Mouse, 3 Year Battery Life, Blue",
                            ImageThumbnailUrl = "\\Images\\Catalog\\logitech-wireless-mouse.jpg",
                            ImageUrl = "\\Images\\Catalog\\logitech-wireless-mouse.jpg",
                            IsRecommended = false,
                            Make = "Logitech",
                            Name = "Logitech Wireless Mouse",
                            Price = 119.99m
                        },
                        new
                        {
                            ItemId = 4,
                            CategoryId = 3,
                            Description = "Wired Gaming Mouse, 11 Programmable Buttons",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Logitech Performance Mouse.jpg",
                            ImageUrl = "\\Images\\Catalog\\Logitech Performance Mouse.jpg",
                            IsRecommended = false,
                            Make = "Logitech",
                            Name = "Logitech High Performance Mouse",
                            Price = 349.99m
                        },
                        new
                        {
                            ItemId = 5,
                            CategoryId = 4,
                            Description = "Noise Cancelling Headphones, Black/Red",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Sony Headphones.jpg",
                            ImageUrl = "\\Images\\Catalog\\Sony Headphones.jpg",
                            IsRecommended = false,
                            Make = "Sony",
                            Name = "Sony Headphones",
                            Price = 599.99m
                        },
                        new
                        {
                            ItemId = 6,
                            CategoryId = 1,
                            Description = "Gaming Monitor, 2560x1440, 144Hz, Curved",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Samsung Odyssey Montior.jpg",
                            ImageUrl = "\\Images\\Catalog\\Samsung Odyssey Montior.jpg",
                            IsRecommended = true,
                            Make = "Samsung",
                            Name = "Samsung Odyssey Montior",
                            Price = 899.99m
                        },
                        new
                        {
                            ItemId = 7,
                            CategoryId = 1,
                            Description = "Zero Frame Monitor, 1920x1080",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Acer Full HD Monitor.jpg",
                            ImageUrl = "\\Images\\Catalog\\Acer Full HD Monitor.jpg",
                            IsRecommended = false,
                            Make = "acer",
                            Name = "Acer Full HD Monitor",
                            Price = 799.99m
                        },
                        new
                        {
                            ItemId = 8,
                            CategoryId = 2,
                            Description = "Wireless",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Logitech Keyboard.jpg",
                            ImageUrl = "\\Images\\Catalog\\Logitech Keyboard.jpg",
                            IsRecommended = false,
                            Make = "logitech",
                            Name = "Logitech Keyboard",
                            Price = 110.00m
                        },
                        new
                        {
                            ItemId = 9,
                            CategoryId = 4,
                            Description = "Over-Ear Wireless Headphones",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Bose Headphones.jpg",
                            ImageUrl = "\\Images\\Catalog\\Bose Headphones.jpg",
                            IsRecommended = false,
                            Make = "bose",
                            Name = "Bose Headphones",
                            Price = 649.99m
                        },
                        new
                        {
                            ItemId = 10,
                            CategoryId = 2,
                            Description = "Huntsman Tournament Edition",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Razer Gaming Keyboard.jpg",
                            ImageUrl = "\\Images\\Catalog\\Razer Gaming Keyboard.jpg",
                            IsRecommended = false,
                            Make = "razer",
                            Name = "Razer Gaming Keyboard",
                            Price = 249.99m
                        },
                        new
                        {
                            ItemId = 11,
                            CategoryId = 1,
                            Description = "Curved UltraWide, 3440x1440, Borderless Display",
                            ImageThumbnailUrl = "\\Images\\Catalog\\LG Curved Monitor.jpg",
                            ImageUrl = "\\Images\\Catalog\\LG Curved Monitor.jpg",
                            IsRecommended = true,
                            Make = "lg",
                            Name = "LG Curved Monitor",
                            Price = 2909.99m
                        },
                        new
                        {
                            ItemId = 12,
                            CategoryId = 1,
                            Description = "Curved Gaming Monitor, 144Hz, Black",
                            ImageThumbnailUrl = "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg",
                            ImageUrl = "\\Images\\Catalog\\Asus Curved Gaming Monitor.jpg",
                            IsRecommended = false,
                            Make = "asus",
                            Name = "Asus Curved Gaming Monitor",
                            Price = 1559.99m
                        },
                        new
                        {
                            ItemId = 13,
                            CategoryId = 5,
                            Description = "Multifunction Wireless Laser Printer, White",
                            ImageThumbnailUrl = "\\Images\\Catalog\\HP LaserJet Printer.jpg",
                            ImageUrl = "\\Images\\Catalog\\HP LaserJet Printer.jpg",
                            IsRecommended = false,
                            Make = "hp",
                            Name = "HP LaserJet Printer",
                            Price = 1799.99m
                        });
                });

            modelBuilder.Entity("MixedShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(65)
                        .HasColumnType("nvarchar(65)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
