﻿// <auto-generated />
using FYPSwaggerApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FYPSwaggerApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FYPSwaggerApi.Models.date_model", b =>
                {
                    b.Property<int>("dateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dateId"));

                    b.Property<string>("current_Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dateId");

                    b.ToTable("dateTime");
                });

            modelBuilder.Entity("FYPSwaggerApi.Models.employee_model", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<string>("employeeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FYPSwaggerApi.Models.item_model", b =>
                {
                    b.Property<int>("itemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("itemId"));

                    b.Property<string>("itemDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemLeft")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("itemPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("itemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FYPSwaggerApi.Models.note_model", b =>
                {
                    b.Property<int>("noteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("noteId"));

                    b.Property<string>("dateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("noteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("FYPSwaggerApi.Models.order_model", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderId"));

                    b.Property<string>("dateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderItemDescritpion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderItemPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("orderQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("orderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FYPSwaggerApi.Models.user_model", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}