﻿// <auto-generated />
using System;
using KraveBazaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KraveBazaAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250211203432_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.13");

            modelBuilder.Entity("KraveBazaAPI.Entities.Krava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DatumOsemenjavanja")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImeMajke")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Injekcija")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("MoguceOsemenjavanje")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Provera")
                        .HasColumnType("TEXT");

                    b.Property<int>("RedniBroj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("SteonostPregled")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TeljenjeDatum")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TeljenjeTermin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Vakcina10Dana")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Vakcina3Dana")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Zasusivanje")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Krave");
                });
#pragma warning restore 612, 618
        }
    }
}
