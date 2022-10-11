﻿// <auto-generated />
using System;
using IPS_Backend.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IPS_Backend.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IPS_Backend.DataModels.Inventory", b =>
                {
                    b.Property<int>("inventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("inventoryID");

                    b.HasIndex("userID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.Item", b =>
                {
                    b.Property<int>("itemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("inventoryID")
                        .HasColumnType("int");

                    b.Property<string>("itemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemStats")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itemID");

                    b.HasIndex("inventoryID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.Inventory", b =>
                {
                    b.HasOne("IPS_Backend.DataModels.User", null)
                        .WithMany("inventories")
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.Item", b =>
                {
                    b.HasOne("IPS_Backend.DataModels.Inventory", null)
                        .WithMany("items")
                        .HasForeignKey("inventoryID");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.Inventory", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("IPS_Backend.DataModels.User", b =>
                {
                    b.Navigation("inventories");
                });
#pragma warning restore 612, 618
        }
    }
}
