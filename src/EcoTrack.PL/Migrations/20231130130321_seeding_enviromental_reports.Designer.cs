﻿// <auto-generated />
using System;
using EcoTrack.PL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcoTrack.PL.Migrations
{
    [DbContext(typeof(EcoTrackDBContext))]
    [Migration("20231130130321_seeding_enviromental_reports")]
    partial class seedingenviromentalreports
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EcoTrack.PL.Entities.EnviromentalReport", b =>
                {
                    b.Property<long>("EnviromentalReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("EnviromentalReportsTopicId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<double>("Value")
                        .HasColumnType("double");

                    b.HasKey("EnviromentalReportId");

                    b.HasIndex("EnviromentalReportsTopicId");

                    b.HasIndex("UserId");

                    b.ToTable("EnviromentalReports");

                    b.HasData(
                        new
                        {
                            EnviromentalReportId = -10L,
                            EnviromentalReportsTopicId = -3L,
                            IsDeleted = false,
                            ReportDate = new DateTime(2023, 11, 30, 13, 3, 21, 400, DateTimeKind.Utc).AddTicks(4164),
                            UserId = -9L,
                            Value = 80.0
                        },
                        new
                        {
                            EnviromentalReportId = -9L,
                            EnviromentalReportsTopicId = -2L,
                            IsDeleted = false,
                            ReportDate = new DateTime(2023, 11, 30, 13, 3, 21, 400, DateTimeKind.Utc).AddTicks(4166),
                            UserId = -9L,
                            Value = 81.400000000000006
                        });
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.EnviromentalReportsTopic", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("enviromentalReportsTopics");

                    b.HasData(
                        new
                        {
                            Id = -3L,
                            Name = "Temperature"
                        },
                        new
                        {
                            Id = -2L,
                            Name = "Air quality"
                        },
                        new
                        {
                            Id = -1L,
                            Name = "Water quality"
                        });
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.Location", b =>
                {
                    b.Property<long>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = -10L,
                            CityName = "Nablus",
                            CountryName = "Palestine"
                        },
                        new
                        {
                            LocationId = -9L,
                            CityName = "Jenin",
                            CountryName = "Palestine"
                        },
                        new
                        {
                            LocationId = -8L,
                            CityName = "Tokyo",
                            CountryName = "Japan"
                        },
                        new
                        {
                            LocationId = -7L,
                            CityName = "Seoul",
                            CountryName = "North Korea"
                        });
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserLevel")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = -10L,
                            BirthDate = new DateTime(2023, 11, 30, 15, 3, 21, 400, DateTimeKind.Local).AddTicks(4093),
                            Deleted = false,
                            Email = "morsee@egy.pt",
                            FirstName = "Mer'e",
                            LastName = "Pharaoh",
                            LocationId = -10L,
                            Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8",
                            UserLevel = 1,
                            Username = "morse"
                        },
                        new
                        {
                            UserId = -9L,
                            BirthDate = new DateTime(2023, 11, 30, 15, 3, 21, 400, DateTimeKind.Local).AddTicks(4136),
                            Deleted = false,
                            Email = "moghrabi@egy.pt",
                            FirstName = "Sal",
                            LastName = "Tan",
                            LocationId = -8L,
                            Password = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8",
                            UserLevel = 1,
                            Username = "mohammad"
                        });
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.EnviromentalReport", b =>
                {
                    b.HasOne("EcoTrack.PL.Entities.EnviromentalReportsTopic", "EnviromentalReportsTopic")
                        .WithMany()
                        .HasForeignKey("EnviromentalReportsTopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcoTrack.PL.Entities.User", "User")
                        .WithMany("enviromentalReports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnviromentalReportsTopic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.User", b =>
                {
                    b.HasOne("EcoTrack.PL.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("EcoTrack.PL.Entities.User", b =>
                {
                    b.Navigation("enviromentalReports");
                });
#pragma warning restore 612, 618
        }
    }
}
