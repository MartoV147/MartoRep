﻿// <auto-generated />
using System;
using DnDLibraly.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DnDLibraly.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200617160629_nigga")]
    partial class nigga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DnDLibraly.Models.Adventurer", b =>
                {
                    b.Property<int>("AdventurerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AttackPoints")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("DefensePoints")
                        .HasColumnType("float");

                    b.Property<double>("HealthPoints")
                        .HasColumnType("float");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<double>("ManaPoints")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("AdventurerId");

                    b.ToTable("Adventurers");
                });

            modelBuilder.Entity("DnDLibraly.Models.Fight", b =>
                {
                    b.Property<int>("FightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpPoints")
                        .HasColumnType("int");

                    b.Property<double>("PriceWon")
                        .HasColumnType("float");

                    b.Property<string>("Terrain")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("FightId");

                    b.ToTable("Fights");
                });

            modelBuilder.Entity("DnDLibraly.Models.MIdWareTables.AdventurerFight", b =>
                {
                    b.Property<int>("AdventurerId")
                        .HasColumnType("int");

                    b.Property<int>("FightId")
                        .HasColumnType("int");

                    b.HasKey("AdventurerId", "FightId");

                    b.HasIndex("FightId");

                    b.ToTable("AdventurerFights");
                });

            modelBuilder.Entity("DnDLibraly.Models.MIdWareTables.MonsterFight", b =>
                {
                    b.Property<int>("MonsterId")
                        .HasColumnType("int");

                    b.Property<int>("FightId")
                        .HasColumnType("int");

                    b.HasKey("MonsterId", "FightId");

                    b.HasIndex("FightId");

                    b.ToTable("MonsterFights");
                });

            modelBuilder.Entity("DnDLibraly.Models.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AttackPoints")
                        .HasColumnType("float");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<double>("DefensePoints")
                        .HasColumnType("float");

                    b.Property<int>("ExPoints")
                        .HasColumnType("int");

                    b.Property<double>("HealthPoints")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("MonsterId");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("DnDLibraly.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DnDLibraly.Models.MIdWareTables.AdventurerFight", b =>
                {
                    b.HasOne("DnDLibraly.Models.Adventurer", "Adventurer")
                        .WithMany("AdventurerFight")
                        .HasForeignKey("AdventurerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnDLibraly.Models.Fight", "Fight")
                        .WithMany("AdventurerFight")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DnDLibraly.Models.MIdWareTables.MonsterFight", b =>
                {
                    b.HasOne("DnDLibraly.Models.Fight", "Fight")
                        .WithMany("MonsterFight")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DnDLibraly.Models.Monster", "Monster")
                        .WithMany("MonsterFight")
                        .HasForeignKey("MonsterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
