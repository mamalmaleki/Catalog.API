﻿// <auto-generated />
using System;
using Catalog.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Catalog.Domain.Entities.Artist", b =>
                {
                    b.Property<Guid?>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists", "catalog");
                });

            modelBuilder.Entity("Catalog.Domain.Entities.Genre", b =>
                {
                    b.Property<Guid?>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres", "catalog");
                });

            modelBuilder.Entity("Catalog.Domain.Entities.Item", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("AvailableStock")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsInactive")
                        .HasColumnType("bit");

                    b.Property<string>("LabelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("ReleaseDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Items", "catalog");
                });

            modelBuilder.Entity("Catalog.Domain.Entities.Item", b =>
                {
                    b.HasOne("Catalog.Domain.Entities.Artist", "Artist")
                        .WithMany("Items")
                        .HasForeignKey("ArtistId");

                    b.HasOne("Catalog.Domain.Entities.Genre", "Genre")
                        .WithMany("Items")
                        .HasForeignKey("GenreId");

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Catalog.Domain.Entities.Artist", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Catalog.Domain.Entities.Genre", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}