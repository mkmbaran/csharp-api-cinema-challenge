﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("customer_created_date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("customer_updated_date");

                    b.HasKey("Id");

                    b.ToTable("customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3915),
                            Email = "ola@nordmann.no",
                            Name = "Ola Nordmann",
                            Phone = "+123456789",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3916)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3918),
                            Email = "kari@nordmann.no",
                            Name = "Kari Nordmann",
                            Phone = "+987654321",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3918)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("movie_created_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("movie_runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("movie_updated_date");

                    b.HasKey("Id");

                    b.ToTable("movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3944),
                            Description = "You won't believe what happens",
                            Rating = "PG-13",
                            RuntimeMins = 120,
                            Title = "Titanic",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3945)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3946),
                            Description = "With a pencil",
                            Rating = "M-17",
                            RuntimeMins = 90,
                            Title = "John Wick",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3946)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3947),
                            Description = "He's beginning to believe",
                            Rating = "PG-13",
                            RuntimeMins = 120,
                            Title = "Matrix",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3947)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("screening_capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_created_date");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screening_screennumber");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_start_date");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_updated_date");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screening");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3959),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3959),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3960)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3966),
                            MovieId = 2,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3966),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3967)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3968),
                            MovieId = 3,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3967),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3968)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969),
                            MovieId = 1,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3969)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3970)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3971)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3972)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973),
                            MovieId = 2,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3973)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974),
                            MovieId = 3,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3974)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975),
                            MovieId = 1,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3975)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 50,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3976),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3976),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 25,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977),
                            MovieId = 3,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3977),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3978)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_created_date");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("ticket_num_seats");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("screening_updated_date");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3998),
                            CustomerId = 1,
                            NumSeats = 2,
                            ScreeningId = 4,
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3998)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3999),
                            CustomerId = 2,
                            NumSeats = 2,
                            ScreeningId = 4,
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(3999)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4000),
                            CustomerId = 1,
                            NumSeats = 2,
                            ScreeningId = 9,
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4000)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4001),
                            CustomerId = 2,
                            NumSeats = 2,
                            ScreeningId = 9,
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4001)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4002),
                            CustomerId = 1,
                            NumSeats = 1,
                            ScreeningId = 11,
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 40, 33, 246, DateTimeKind.Utc).AddTicks(4002)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}