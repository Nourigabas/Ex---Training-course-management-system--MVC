﻿// <auto-generated />
using System;
using Ex___Training_course_management_system__MVC.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ex___Training_course_management_system__MVC.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20241103224834_Add-restrictions-to-data")]
    partial class Addrestrictionstodata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ex___Training_course_management_system__MVC.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DurationHours")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("InstructorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("377f3c4f-f5a3-4f4a-bf09-ecc85759fa60"),
                            Description = "Learn the basics of programming using C#.",
                            DurationHours = 40,
                            EndDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = new Guid("c100db04-6046-40e6-889f-7a4456ffd460"),
                            IsDelete = false,
                            Name = "Introduction to Programming",
                            StartDate = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e95d83b0-6cfe-4c90-97fc-a22343c408e7"),
                            Description = "Build dynamic websites using ASP.NET Core.",
                            DurationHours = 60,
                            EndDate = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"),
                            IsDelete = false,
                            Name = "Web Development with ASP.NET",
                            StartDate = new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("76cb4aea-bd20-42a8-80e7-feeb8a35c524"),
                            Description = "An introduction to data science concepts and tools.",
                            DurationHours = 50,
                            EndDate = new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"),
                            IsDelete = false,
                            Name = "Data Science Basics",
                            StartDate = new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Ex___Training_course_management_system__MVC.Models.Instructor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c100db04-6046-40e6-889f-7a4456ffd460"),
                            Email = "john.smith@example.com",
                            Name = "John Smith"
                        },
                        new
                        {
                            Id = new Guid("fd645597-2daa-42f7-ad88-ed0766345c56"),
                            Email = "emma.johnson@example.com",
                            Name = "Emma Johnson"
                        },
                        new
                        {
                            Id = new Guid("4053f11d-e58c-4354-9af3-e05a512203ec"),
                            Email = "michael.brown@example.com",
                            Name = "Michael Brown"
                        });
                });

            modelBuilder.Entity("Ex___Training_course_management_system__MVC.Models.Course", b =>
                {
                    b.HasOne("Ex___Training_course_management_system__MVC.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("Ex___Training_course_management_system__MVC.Models.Instructor", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}