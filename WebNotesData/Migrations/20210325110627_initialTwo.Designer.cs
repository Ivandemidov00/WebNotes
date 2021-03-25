﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebNotesData.Models;

namespace WebNotesData.Migrations
{
    [DbContext(typeof(WebNotesContext))]
    [Migration("20210325110627_initialTwo")]
    partial class initialTwo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebNotesData.Models.categories", b =>
                {
                    b.Property<short>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("WebNotesData.Models.posts", b =>
                {
                    b.Property<short>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<short?>("categoriesid")
                        .HasColumnType("smallint");

                    b.Property<short>("id_category")
                        .HasColumnType("smallint");

                    b.Property<short>("id_user")
                        .HasColumnType("smallint");

                    b.Property<string>("post")
                        .HasColumnType("text");

                    b.Property<short?>("userid")
                        .HasColumnType("smallint");

                    b.HasKey("id");

                    b.HasIndex("categoriesid");

                    b.HasIndex("userid");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("WebNotesData.Models.user", b =>
                {
                    b.Property<short>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("WebNotesData.Models.posts", b =>
                {
                    b.HasOne("WebNotesData.Models.categories", "categories")
                        .WithMany("posts")
                        .HasForeignKey("categoriesid");

                    b.HasOne("WebNotesData.Models.user", "user")
                        .WithMany("posts")
                        .HasForeignKey("userid");

                    b.Navigation("categories");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebNotesData.Models.categories", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("WebNotesData.Models.user", b =>
                {
                    b.Navigation("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
