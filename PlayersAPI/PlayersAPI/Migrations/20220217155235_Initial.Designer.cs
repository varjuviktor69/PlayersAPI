﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayersAPI.Models;

namespace PlayersAPI.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20220217155235_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("PlayersAPI.Models.Club", b =>
                {
                    b.Property<int>("ClubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClubName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("League")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ManagerName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("ClubID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("PlayersAPI.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("ClubID")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(3,2)");

                    b.HasKey("PlayerID");

                    b.HasIndex("ClubID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PlayersAPI.Models.Player", b =>
                {
                    b.HasOne("PlayersAPI.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubID");

                    b.Navigation("Club");
                });
#pragma warning restore 612, 618
        }
    }
}
