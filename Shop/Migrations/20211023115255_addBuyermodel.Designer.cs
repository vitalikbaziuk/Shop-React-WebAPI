﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211023115255_addBuyermodel")]
    partial class addBuyermodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Shop.Data.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Shop.Data.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_DirectX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_Graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_OS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Min_Storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Rec_DirectX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rec_Graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rec_Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rec_OS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rec_Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rec_Storage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Shop.Data.Models.GameGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenres");
                });

            modelBuilder.Entity("Shop.Data.Models.GamePlatform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlatformId");

                    b.ToTable("GamePlatforms");
                });

            modelBuilder.Entity("Shop.Data.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Shop.Data.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");
                });

            modelBuilder.Entity("Shop.Data.Models.Game", b =>
                {
                    b.HasOne("Shop.Data.Models.Buyer", null)
                        .WithMany("Games")
                        .HasForeignKey("BuyerId");
                });

            modelBuilder.Entity("Shop.Data.Models.GameGenre", b =>
                {
                    b.HasOne("Shop.Data.Models.Game", null)
                        .WithMany("GameGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Data.Models.Genre", null)
                        .WithMany("GameGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Data.Models.GamePlatform", b =>
                {
                    b.HasOne("Shop.Data.Models.Game", null)
                        .WithMany("GamePlatforms")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Data.Models.Platform", null)
                        .WithMany("GamePlatforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Data.Models.Buyer", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("Shop.Data.Models.Game", b =>
                {
                    b.Navigation("GameGenres");

                    b.Navigation("GamePlatforms");
                });

            modelBuilder.Entity("Shop.Data.Models.Genre", b =>
                {
                    b.Navigation("GameGenres");
                });

            modelBuilder.Entity("Shop.Data.Models.Platform", b =>
                {
                    b.Navigation("GamePlatforms");
                });
#pragma warning restore 612, 618
        }
    }
}
