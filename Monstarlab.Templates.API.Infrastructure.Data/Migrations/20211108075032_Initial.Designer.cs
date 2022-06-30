﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

#nullable disable

namespace Monstarlab.Templates.API.Infrastructure.Data.Migrations
{
    [DbContext(typeof(MonstarlabDbContext))]
    [Migration("20211108075032_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Monstarlab.Templates.API.Domain.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apartment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"),
                            City = "Aarhus",
                            Country = "Denmark",
                            Floor = "9",
                            Number = "2F",
                            Street = "Mariane Thomsens Gade",
                            ZipCode = "8000"
                        },
                        new
                        {
                            Id = new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b"),
                            City = "Copenhagen",
                            Country = "Denmark",
                            Number = "4",
                            Street = "Orientkaj",
                            ZipCode = "2150"
                        });
                });

            modelBuilder.Entity("Monstarlab.Templates.API.Domain.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("Age")
                        .HasColumnType("bigint");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efb8f31e-cdd3-4d6b-96a3-3ee6fe9ae679"),
                            Age = 32L,
                            DepartmentId = new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"),
                            FirstName = "Morten",
                            LastName = "Turn Pedersen"
                        },
                        new
                        {
                            Id = new Guid("35607bf7-9a00-489d-bf71-bbdb53f2f7d8"),
                            Age = 29L,
                            DepartmentId = new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"),
                            FirstName = "Morten",
                            LastName = "Pløger"
                        },
                        new
                        {
                            Id = new Guid("fa4b4f52-0c8b-4839-bbc1-d33a9bf2ca38"),
                            Age = 31L,
                            DepartmentId = new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b"),
                            FirstName = "Kasper",
                            LastName = "Welner"
                        });
                });

            modelBuilder.Entity("Monstarlab.Templates.API.Domain.Models.Employee", b =>
                {
                    b.HasOne("Monstarlab.Templates.API.Domain.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Monstarlab.Templates.API.Domain.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}