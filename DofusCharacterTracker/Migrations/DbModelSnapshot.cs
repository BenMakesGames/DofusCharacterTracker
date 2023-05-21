﻿// <auto-generated />
using System;
using DofusCharacterTracker.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DofusCharacterTracker.Migrations
{
    [DbContext(typeof(Db))]
    partial class DbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AlmanaxProgress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("UnlockedFrigost")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedMoonIsland")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedOhwymi")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedOtomaiBridgeOfDeath")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedOtomaiIsland")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedPandala")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnlockedWabbitIsland")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.CharacterElement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Element")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("CharacterElements");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.DungeonNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DungeonName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("DungeonNotes");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.ProfessionNote", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CharacterId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("ProfessionNotes");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.CharacterElement", b =>
                {
                    b.HasOne("DofusCharacterTracker.Database.Tables.Character", "Character")
                        .WithMany("Elements")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.DungeonNote", b =>
                {
                    b.HasOne("DofusCharacterTracker.Database.Tables.Character", "Character")
                        .WithMany("DungeonNotes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.ProfessionNote", b =>
                {
                    b.HasOne("DofusCharacterTracker.Database.Tables.Character", "Character")
                        .WithMany("ProfessionNotes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DofusCharacterTracker.Database.Tables.Character", b =>
                {
                    b.Navigation("DungeonNotes");

                    b.Navigation("Elements");

                    b.Navigation("ProfessionNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
