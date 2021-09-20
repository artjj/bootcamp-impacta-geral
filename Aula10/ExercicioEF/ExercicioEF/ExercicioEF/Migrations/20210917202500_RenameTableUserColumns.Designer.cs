﻿// <auto-generated />
using System;
using ExercicioEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExercicioEF.Migrations
{
    [DbContext(typeof(ExercicioEFDbContext))]
    [Migration("20210917202500_RenameTableUserColumns")]
    partial class RenameTableUserColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExercicioEF.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USER")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("VARCHAR(11)")
                        .HasColumnName("DS_CPF");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATE")
                        .HasColumnName("DT_NASC");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NM_USER");

                    b.HasKey("Id");

                    b.ToTable("TB_USER");
                });
#pragma warning restore 612, 618
        }
    }
}