﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace kidsbehaviortracker.Migrations
{
    [DbContext(typeof(KidsContext))]
    [Migration("20240321194818_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Data.Bonus", b =>
                {
                    b.Property<int>("BonusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BonusId");

                    b.ToTable("Bonus");
                });

            modelBuilder.Entity("Data.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Color")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("KidId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RuleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardId");

                    b.HasIndex("KidId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Data.Kid", b =>
                {
                    b.Property<int>("KidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("KidId");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("Data.WonBonus", b =>
                {
                    b.Property<int>("WonBonusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BonusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<int>("KidId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Used")
                        .HasColumnType("INTEGER");

                    b.HasKey("WonBonusId");

                    b.HasIndex("KidId");

                    b.ToTable("WonBonus");
                });

            modelBuilder.Entity("Data.Card", b =>
                {
                    b.HasOne("Data.Kid", null)
                        .WithMany("Cards")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.WonBonus", b =>
                {
                    b.HasOne("Data.Kid", null)
                        .WithMany("WonBonus")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Kid", b =>
                {
                    b.Navigation("Cards");

                    b.Navigation("WonBonus");
                });
#pragma warning restore 612, 618
        }
    }
}
