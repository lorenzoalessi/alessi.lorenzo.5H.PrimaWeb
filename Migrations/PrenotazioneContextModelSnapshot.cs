﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using alessi.lorenzo._5H.PrimaWeb.Models;

namespace alessi.lorenzo._5H.PrimaWeb.Migrations
{
    [DbContext(typeof(PrenotazioneContext))]
    partial class PrenotazioneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("alessi.lorenzo._5H.PrimaWeb.Models.Prenotazione", b =>
                {
                    b.Property<int>("PrenotazioneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("PrenotazioneId");

                    b.ToTable("Prenotazioni");
                });
#pragma warning restore 612, 618
        }
    }
}
