﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TM470GradeCalc.Data;

#nullable disable

namespace TM470GradeCalc.Migrations
{
    [DbContext(typeof(TM470Context))]
    [Migration("20240831115042_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TM470GradeCalc.Models.GradeCalc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CalculationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("EMA")
                        .HasColumnType("float");

                    b.Property<double>("TMA1")
                        .HasColumnType("float");

                    b.Property<double>("TMA2")
                        .HasColumnType("float");

                    b.Property<double>("TMA3")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TM470Grades");
                });
#pragma warning restore 612, 618
        }
    }
}