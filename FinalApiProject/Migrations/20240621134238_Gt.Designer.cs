﻿// <auto-generated />
using System;
using FinalApiProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalApiProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240621134238_Gt")]
    partial class Gt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalApiProject.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegreeId"), 1L, 1);

                    b.Property<string>("DegreeName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("DegreeId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("FinalApiProject.Models.GraduateTrainee", b =>
                {
                    b.Property<int>("GraduateTraineeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GraduateTraineeId"), 1L, 1);

                    b.Property<decimal?>("AI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("BusinessAnalysis")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateOfApplication")
                        .HasColumnType("datetime2");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GraduateTraineeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraduateTraineeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("IsAdmissionConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLastSemesterPending")
                        .HasColumnType("bit");

                    b.Property<decimal?>("MachineLearning")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Percentages")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Practical")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Python")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("TotalMarks")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GraduateTraineeId");

                    b.HasIndex("DegreeId");

                    b.ToTable("GraduateTrainees");
                });

            modelBuilder.Entity("FinalApiProject.Models.GraduateTrainee", b =>
                {
                    b.HasOne("FinalApiProject.Models.Degree", "Degree")
                        .WithMany("GraduateTrainees")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Degree");
                });

            modelBuilder.Entity("FinalApiProject.Models.Degree", b =>
                {
                    b.Navigation("GraduateTrainees");
                });
#pragma warning restore 612, 618
        }
    }
}
