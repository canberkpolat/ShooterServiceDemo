﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShooterServiceDemo.Contexts;

namespace ShooterServiceDemo.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200911122753_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShooterServiceDemo.Models.ContextModels.ShootingRecord", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DeadID")
                        .HasColumnType("int");

                    b.Property<int>("HitZoneID")
                        .HasColumnType("int");

                    b.Property<int>("ShooterID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShootingTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("ShootingRecords");
                });

            modelBuilder.Entity("ShooterServiceDemo.Models.ContextModels.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShooterServiceDemo.Models.ContextModels.ShootingRecord", b =>
                {
                    b.HasOne("ShooterServiceDemo.Models.ContextModels.User", null)
                        .WithMany("Shootings")
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
