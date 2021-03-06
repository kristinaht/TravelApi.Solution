﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20200330222142_AddUserModel")]
    partial class AddUserModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Rating");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Author = "Michelle",
                            City = "Paris",
                            Country = "France",
                            Description = "too crowded, some cool art",
                            Destination = "Louvre",
                            Rating = 3
                        },
                        new
                        {
                            ReviewId = 2,
                            Author = "Joe",
                            City = "Cartago",
                            Country = "Costa Rica",
                            Description = "it's a volcano",
                            Destination = "Irazu volcano national park",
                            Rating = 4
                        },
                        new
                        {
                            ReviewId = 3,
                            Author = "Cletus",
                            City = "Cedar Creek",
                            Country = "Canada",
                            Description = "real nice",
                            Destination = "The sticks",
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 4,
                            Author = "James",
                            City = "Sydney",
                            Country = "Australia",
                            Description = "It was aight",
                            Destination = "Da Club",
                            Rating = 3
                        });
                });

            modelBuilder.Entity("TravelApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Token");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
