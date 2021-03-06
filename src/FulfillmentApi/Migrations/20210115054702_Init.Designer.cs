﻿// <auto-generated />
using FulfillmentApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FulfillmentApi.Migrations
{
    [DbContext(typeof(FulfillmentDbContext))]
    [Migration("20210115054702_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Fulfillment")
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("FulfillmentApi.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("OrderNo")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.HasKey("OrderItemId");

                    b.ToTable("tblOrderItem");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            OrderNo = 1,
                            ProductId = 1,
                            Status = "shipped"
                        },
                        new
                        {
                            OrderItemId = 2,
                            OrderNo = 2,
                            ProductId = 1,
                            Status = "shipped"
                        },
                        new
                        {
                            OrderItemId = 3,
                            OrderNo = 2,
                            ProductId = 2,
                            Status = "pending"
                        },
                        new
                        {
                            OrderItemId = 4,
                            OrderNo = 2,
                            ProductId = 2,
                            Status = "pending"
                        },
                        new
                        {
                            OrderItemId = 5,
                            OrderNo = 3,
                            ProductId = 4,
                            Status = "canceled"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
