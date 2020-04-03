﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShelterAPI.Models;

namespace ShelterAPI.Migrations
{
    [DbContext(typeof(ShelterAPIContext))]
    [Migration("20200403171217_SeedAnimals")]
    partial class SeedAnimals
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShelterAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Breed");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 3,
                            Breed = "Bobtail",
                            Gender = "Male",
                            Name = "Bert",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            Breed = "Siamese",
                            Gender = "Female",
                            Name = "Alice",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            Breed = "Shorthair",
                            Gender = "Male",
                            Name = "Alfred",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Breed = "Maine Coon",
                            Gender = "Female",
                            Name = "Margo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 12,
                            Breed = "Dachsund",
                            Gender = "Male",
                            Name = "Andrew",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 6,
                            Breed = "Mixed",
                            Gender = "Male",
                            Name = "Eduardo",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 4,
                            Breed = "Shih Tzu",
                            Gender = "Female",
                            Name = "Angela",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 10,
                            Breed = "Dalmation",
                            Gender = "Male",
                            Name = "Bingo",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
