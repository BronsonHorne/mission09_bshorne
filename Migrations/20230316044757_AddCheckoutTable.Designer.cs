﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission09_bshorne.Models;

namespace mission09_bshorne.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20230316044757_AddCheckoutTable")]
    partial class AddCheckoutTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("mission09_bshorne.Models.BasketLineItem", b =>
                {
                    b.Property<int>("LineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CheckoutId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineID");

                    b.HasIndex("BookId");

                    b.HasIndex("CheckoutId");

                    b.ToTable("BasketLineItem");
                });

            modelBuilder.Entity("mission09_bshorne.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("mission09_bshorne.Models.Checkout", b =>
                {
                    b.Property<int>("CheckoutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CheckoutId");

                    b.ToTable("Checkout");
                });

            modelBuilder.Entity("mission09_bshorne.Models.BasketLineItem", b =>
                {
                    b.HasOne("mission09_bshorne.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("mission09_bshorne.Models.Checkout", null)
                        .WithMany("Lines")
                        .HasForeignKey("CheckoutId");
                });
#pragma warning restore 612, 618
        }
    }
}
