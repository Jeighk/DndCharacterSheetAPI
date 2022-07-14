﻿// <auto-generated />
using DndCharacterSheetAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DndCharacterSheetAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220709180645_thirdPush")]
    partial class thirdPush
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("DndCharacterSheetAPI.Models.CharacterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("Alignment")
                        .HasColumnType("integer");

                    b.Property<string>("Background")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Charisma")
                        .HasColumnType("integer");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Constituion")
                        .HasColumnType("integer");

                    b.Property<int>("Dexterity")
                        .HasColumnType("integer");

                    b.Property<decimal>("Gold")
                        .HasColumnType("numeric");

                    b.Property<int>("Intelligence")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("MaxHitPoints")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Speed")
                        .HasColumnType("integer");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("Wisdom")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DndCharacterSheetAPI.Models.FlawModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Flaws");
                });

            modelBuilder.Entity("DndCharacterSheetAPI.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DndCharacterSheetAPI.Models.LanguageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DndCharacterSheetAPI.Models.ProficiencyModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Proficiencies");
                });
#pragma warning restore 612, 618
        }
    }
}