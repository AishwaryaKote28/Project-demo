﻿// <auto-generated />
using System;
using InstituteManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstituteManagementSystem.Migrations.DataBase
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220413061405_CreateReletionshipChangedTable")]
    partial class CreateReletionshipChangedTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstituteManagementSystem.Model.CourseDetails", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fees")
                        .HasColumnType("float");

                    b.HasKey("CourseId");

                    b.ToTable("CourseDetails");
                });

            modelBuilder.Entity("InstituteManagementSystem.Model.FeesDetails", b =>
                {
                    b.Property<int>("RecieptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaidFees")
                        .HasColumnType("int");

                    b.Property<int>("PendingFees")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecieptId");

                    b.ToTable("FeesDetails");
                });

            modelBuilder.Entity("InstituteManagementSystem.Model.StudentAdmissionDetails", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdharNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseDetailsCourseId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("HighestQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseDetailsCourseId");

                    b.ToTable("StudentAdmissionDetails");
                });

            modelBuilder.Entity("InstituteManagementSystem.Model.StudentAdmissionDetails", b =>
                {
                    b.HasOne("InstituteManagementSystem.Model.CourseDetails", "CourseDetails")
                        .WithMany()
                        .HasForeignKey("CourseDetailsCourseId");

                    b.Navigation("CourseDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
