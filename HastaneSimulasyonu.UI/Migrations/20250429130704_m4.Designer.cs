﻿// <auto-generated />
using System;
using HastaneSimulasyonu.UI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HastaneSimulasyonu.UI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250429130704_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Bolum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bolum");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BolumId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BolumId");

                    b.ToTable("Doktor");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sikayet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hasta");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoktorId")
                        .HasColumnType("int");

                    b.Property<int>("HastaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoktorId");

                    b.HasIndex("HastaId");

                    b.ToTable("Randevu");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Doktor", b =>
                {
                    b.HasOne("HastaneSimulasyonu.UI.Models.Bolum", "Bolum")
                        .WithMany("Doktorlar")
                        .HasForeignKey("BolumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Randevu", b =>
                {
                    b.HasOne("HastaneSimulasyonu.UI.Models.Doktor", "Doktor")
                        .WithMany("Randevular")
                        .HasForeignKey("DoktorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HastaneSimulasyonu.UI.Models.Hasta", "Hasta")
                        .WithMany("Randevular")
                        .HasForeignKey("HastaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doktor");

                    b.Navigation("Hasta");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Bolum", b =>
                {
                    b.Navigation("Doktorlar");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Doktor", b =>
                {
                    b.Navigation("Randevular");
                });

            modelBuilder.Entity("HastaneSimulasyonu.UI.Models.Hasta", b =>
                {
                    b.Navigation("Randevular");
                });
#pragma warning restore 612, 618
        }
    }
}
