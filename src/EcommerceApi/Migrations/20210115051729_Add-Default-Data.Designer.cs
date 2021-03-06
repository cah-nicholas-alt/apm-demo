﻿// <auto-generated />
using EcommerceApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EcommerceApi.Migrations
{
    [DbContext(typeof(EcommerceDbContext))]
    [Migration("20210115051729_Add-Default-Data")]
    partial class AddDefaultData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Ecommerce")
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EcommerceApi.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("GrandTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Taxes")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("tblOrder");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            GrandTotal = 10.7m,
                            OrderTotal = 10.0m,
                            Taxes = 0.70m,
                            UserId = "nick"
                        },
                        new
                        {
                            OrderId = 2,
                            GrandTotal = 21.2m,
                            OrderTotal = 20.0m,
                            Taxes = 1.2m,
                            UserId = "bob"
                        },
                        new
                        {
                            OrderId = 3,
                            GrandTotal = 0.00m,
                            OrderTotal = 0.0m,
                            Taxes = 0.00m,
                            UserId = "bob"
                        });
                });

            modelBuilder.Entity("EcommerceApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("tblProduct");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Cost = 10m,
                            ProductName = "Product A"
                        },
                        new
                        {
                            ProductId = 2,
                            Cost = 5m,
                            ProductName = "Product B"
                        },
                        new
                        {
                            ProductId = 3,
                            Cost = 14m,
                            ProductName = "Product C"
                        },
                        new
                        {
                            ProductId = 4,
                            Cost = 76m,
                            ProductName = "Product D"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
