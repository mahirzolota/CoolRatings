﻿// <auto-generated />
using System;
using CoolRatings.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoolRatings.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210222132724_changesOnRatingModel")]
    partial class changesOnRatingModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoolRatings.Models.CastModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShowModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowModelId");

                    b.ToTable("castModels");
                });

            modelBuilder.Entity("CoolRatings.Models.RatingsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ShowModelId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isUser")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ShowModelId");

                    b.HasIndex("UserId");

                    b.ToTable("ratingsModels");
                });

            modelBuilder.Entity("CoolRatings.Models.ShowModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("showModels");
                });

            modelBuilder.Entity("CoolRatings.Models.TypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("typeModels");
                });

            modelBuilder.Entity("CoolRatings.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("userModels");
                });

            modelBuilder.Entity("CoolRatings.Models.CastModel", b =>
                {
                    b.HasOne("CoolRatings.Models.ShowModel", null)
                        .WithMany("Cast")
                        .HasForeignKey("ShowModelId");
                });

            modelBuilder.Entity("CoolRatings.Models.RatingsModel", b =>
                {
                    b.HasOne("CoolRatings.Models.ShowModel", "ShowModel")
                        .WithMany("Ratings")
                        .HasForeignKey("ShowModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoolRatings.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ShowModel");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoolRatings.Models.ShowModel", b =>
                {
                    b.HasOne("CoolRatings.Models.TypeModel", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("CoolRatings.Models.ShowModel", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
