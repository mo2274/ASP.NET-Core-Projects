﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pie2Shop.Models;

namespace Pie2Shop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220215130823_Add orders")]
    partial class Addorders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Pie2Shop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Fruit pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Cheese Cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Seasonal pies"
                        });
                });

            modelBuilder.Entity("Pie2Shop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Enail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Pie2Shop.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PieId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PieId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Pie2Shop.Models.Pie", b =>
                {
                    b.Property<int>("PieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            PieId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "/Images/carousel2.jpg",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            LongDescription = "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        },
                        new
                        {
                            PieId = 2,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "/Images/carousel2.jpg",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        },
                        new
                        {
                            PieId = 3,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "/Images/carousel2.jpg",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        },
                        new
                        {
                            PieId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "/Images/carousel2.jpg",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        },
                        new
                        {
                            PieId = 5,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "/Images/carousel2.jpg",
                            ImageUrl = "",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            LongDescription = "JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!"
                        });
                });

            modelBuilder.Entity("Pie2Shop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("PieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Pie2Shop.Models.OrderDetails", b =>
                {
                    b.HasOne("Pie2Shop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pie2Shop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Pie");
                });

            modelBuilder.Entity("Pie2Shop.Models.Pie", b =>
                {
                    b.HasOne("Pie2Shop.Models.Category", "Category")
                        .WithMany("Pies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pie2Shop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Pie2Shop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieId");

                    b.Navigation("Pie");
                });

            modelBuilder.Entity("Pie2Shop.Models.Category", b =>
                {
                    b.Navigation("Pies");
                });

            modelBuilder.Entity("Pie2Shop.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}