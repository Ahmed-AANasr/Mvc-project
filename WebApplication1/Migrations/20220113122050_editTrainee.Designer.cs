﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DBRelations))]
    [Migration("20220113122050_editTrainee")]
    partial class editTrainee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("WebApplication1.Models.CourseResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Degree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("crs_id")
                        .HasColumnType("int");

                    b.Property<int>("train_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("crs_id");

                    b.HasIndex("train_id");

                    b.ToTable("courseResult");
                });

            modelBuilder.Entity("WebApplication1.Models.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Degree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dep_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("dep_id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApplication1.Models.Department", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("WebApplication1.Models.Instrauctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("crs_id")
                        .HasColumnType("int");

                    b.Property<int>("dep_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("crs_id");

                    b.HasIndex("dep_id");

                    b.ToTable("Instrauctor");
                });

            modelBuilder.Entity("WebApplication1.Models.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Degree")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("crs_id")
                        .HasColumnType("int");

                    b.Property<int>("dep_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("crs_id");

                    b.HasIndex("dep_id");

                    b.ToTable("Trainee");
                });

            modelBuilder.Entity("WebApplication1.Models.CourseResult", b =>
                {
                    b.HasOne("WebApplication1.Models.Courses", "crs")
                        .WithMany()
                        .HasForeignKey("crs_id");

                    b.HasOne("WebApplication1.Models.Trainee", "train")
                        .WithMany()
                        .HasForeignKey("train_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("crs");

                    b.Navigation("train");
                });

            modelBuilder.Entity("WebApplication1.Models.Courses", b =>
                {
                    b.HasOne("WebApplication1.Models.Department", "dep")
                        .WithMany()
                        .HasForeignKey("dep_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dep");
                });

            modelBuilder.Entity("WebApplication1.Models.Instrauctor", b =>
                {
                    b.HasOne("WebApplication1.Models.Courses", "crs")
                        .WithMany()
                        .HasForeignKey("crs_id");

                    b.HasOne("WebApplication1.Models.Department", "dep")
                        .WithMany()
                        .HasForeignKey("dep_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("crs");

                    b.Navigation("dep");
                });

            modelBuilder.Entity("WebApplication1.Models.Trainee", b =>
                {
                    b.HasOne("WebApplication1.Models.Courses", "crs")
                        .WithMany()
                        .HasForeignKey("crs_id");

                    b.HasOne("WebApplication1.Models.Department", "dep")
                        .WithMany()
                        .HasForeignKey("dep_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("crs");

                    b.Navigation("dep");
                });
#pragma warning restore 612, 618
        }
    }
}
