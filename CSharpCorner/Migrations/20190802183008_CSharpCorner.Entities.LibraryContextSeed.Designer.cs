﻿// <auto-generated />
using System;
using CSharpCorner.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharpCorner.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190802183008_CSharpCorner.Entities.LibraryContextSeed")]
    partial class CSharpCornerEntitiesLibraryContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharpCorner.Entities.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AuthorId");

                    b.ToTable("Author","dbo");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("b191f29f-e446-4178-b5ba-b4f3ab0b45a7"),
                            FirstName = "Bob",
                            Genre = "Drama",
                            LastName = "Ross"
                        },
                        new
                        {
                            AuthorId = new Guid("6e99d1d8-282c-4a65-b6de-df3470b0eb85"),
                            FirstName = "David",
                            Genre = "Fantasy",
                            LastName = "Miller"
                        });
                });

            modelBuilder.Entity("CSharpCorner.Entities.Book", b =>
                {
                    b.Property<Guid>("AuthorId");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CSharpCorner.Entities.Book", b =>
                {
                    b.HasOne("CSharpCorner.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
