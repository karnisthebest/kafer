﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace kafer_house.Migrations
{
    [DbContext(typeof(KaferDbContext))]
    [Migration("20190413032314_actual sold")]
    partial class actualsold
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("kafer_house.Models.ActualSold", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date");

                    b.Property<double>("price");

                    b.Property<int>("productID");

                    b.Property<int>("qty");

                    b.Property<int>("shoppingmallID");

                    b.HasKey("id");

                    b.HasIndex("productID");

                    b.HasIndex("shoppingmallID");

                    b.ToTable("ActualSold");
                });

            modelBuilder.Entity("kafer_house.Models.Branch", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<int>("shoppingmallID");

                    b.HasKey("id");

                    b.HasIndex("shoppingmallID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("kafer_house.Models.DeliveryReturn", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date");

                    b.Property<DateTime>("lotdate");

                    b.Property<int>("productID");

                    b.Property<int>("qty");

                    b.Property<int>("shoppingmallID");

                    b.Property<string>("status");

                    b.HasKey("id");

                    b.HasIndex("productID");

                    b.HasIndex("shoppingmallID");

                    b.ToTable("DeliveryReturn");
                });

            modelBuilder.Entity("kafer_house.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("code");

                    b.Property<string>("name");

                    b.Property<double>("price");

                    b.HasKey("id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("kafer_house.Models.SaleOrder", b =>
                {
                    b.Property<int>("saleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("saleAmount");

                    b.Property<string>("zone");

                    b.HasKey("saleID");

                    b.ToTable("SaleOrders");
                });

            modelBuilder.Entity("kafer_house.Models.ShoppingMall", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("ShoppingMall");
                });

            modelBuilder.Entity("kafer_house.Models.ActualSold", b =>
                {
                    b.HasOne("kafer_house.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kafer_house.Models.ShoppingMall", "shoppingmall")
                        .WithMany()
                        .HasForeignKey("shoppingmallID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kafer_house.Models.Branch", b =>
                {
                    b.HasOne("kafer_house.Models.ShoppingMall", "shoppingmall")
                        .WithMany("branchs")
                        .HasForeignKey("shoppingmallID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("kafer_house.Models.DeliveryReturn", b =>
                {
                    b.HasOne("kafer_house.Models.Product", "product")
                        .WithMany("deliveryreturn")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("kafer_house.Models.ShoppingMall", "shoppingmall")
                        .WithMany()
                        .HasForeignKey("shoppingmallID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
