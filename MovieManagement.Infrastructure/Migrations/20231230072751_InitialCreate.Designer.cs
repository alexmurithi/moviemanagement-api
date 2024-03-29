﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManagement.Infrastructure.Context;

#nullable disable

namespace MovieManagement.Infrastructure.Migrations
{
    [DbContext(typeof(MovieManagementDbContext))]
    [Migration("20231230072751_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GenreId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Actor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8f8f7bb-1abf-48cb-ad95-f17d84238955"),
                            CreatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5923),
                            FirstName = "Justin",
                            LastName = "Timberlake",
                            UpdatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5924)
                        },
                        new
                        {
                            Id = new Guid("73bd68da-1a2a-463d-ad4f-0c5d33d9a7cf"),
                            CreatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5926),
                            FirstName = "Chuck",
                            LastName = "Norris",
                            UpdatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5927)
                        },
                        new
                        {
                            Id = new Guid("d0f1858c-541f-4cf5-a5d1-7e97f2e441c6"),
                            CreatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5928),
                            FirstName = "Van",
                            LastName = "Damme",
                            UpdatedAt = new DateTime(2023, 12, 30, 7, 27, 51, 757, DateTimeKind.Utc).AddTicks(5929)
                        });
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Biography", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActorId")
                        .IsUnique();

                    b.ToTable("Biographies");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entity.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieManagement.Domain.Entity.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Biography", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entity.Actor", "Actor")
                        .WithOne("Biography")
                        .HasForeignKey("MovieManagement.Domain.Entity.Biography", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Movie", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entity.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entity.Actor", b =>
                {
                    b.Navigation("Biography");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
