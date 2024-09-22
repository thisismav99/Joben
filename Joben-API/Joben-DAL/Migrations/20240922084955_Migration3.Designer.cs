﻿// <auto-generated />
using System;
using Joben_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Joben_DAL.Migrations
{
    [DbContext(typeof(JobenDbContext))]
    [Migration("20240922084955_Migration3")]
    partial class Migration3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Joben_DAL.Models.RATING.RatingModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Ratings", (string)null);
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.AddressModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Barangay")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.MISC.CivilStatusModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CivilStatus")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("CivilStatus", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CivilStatus = "SINGLE",
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2692),
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CivilStatus = "MARRIED",
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2695),
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            CivilStatus = "ANNULLED",
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2696),
                            IsActive = true
                        },
                        new
                        {
                            ID = 4,
                            CivilStatus = "DIVORCED",
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2698),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.MISC.GenderModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Gender", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2847),
                            Gender = "MALE",
                            IsActive = true
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2849),
                            Gender = "FEMALE",
                            IsActive = true
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2850),
                            Gender = "GAY",
                            IsActive = true
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2851),
                            Gender = "LESBIAN",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.MISC.PositionModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Position", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2873),
                            IsActive = true,
                            Position = "RIDER"
                        },
                        new
                        {
                            ID = 2,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2875),
                            IsActive = true,
                            Position = "DRIVER"
                        },
                        new
                        {
                            ID = 3,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2876),
                            IsActive = true,
                            Position = "HOUSEKEEPER"
                        },
                        new
                        {
                            ID = 4,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2877),
                            IsActive = true,
                            Position = "COOK"
                        },
                        new
                        {
                            ID = 5,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2878),
                            IsActive = true,
                            Position = "GARDENER"
                        },
                        new
                        {
                            ID = 6,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2880),
                            IsActive = true,
                            Position = "BABY SITTER"
                        },
                        new
                        {
                            ID = 7,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2881),
                            IsActive = true,
                            Position = "DELIVERY MAN"
                        },
                        new
                        {
                            ID = 8,
                            CreatedBy = "SEEDER",
                            CreatedOn = new DateTime(2024, 9, 22, 8, 49, 54, 750, DateTimeKind.Utc).AddTicks(2882),
                            IsActive = true,
                            Position = "LAUNDRY"
                        });
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CivilStatusID")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GenderID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CivilStatusID");

                    b.HasIndex("GenderID");

                    b.HasIndex("PositionID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Joben_DAL.Models.RATING.RatingModel", b =>
                {
                    b.HasOne("Joben_DAL.Models.USER.UserModel", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.AddressModel", b =>
                {
                    b.HasOne("Joben_DAL.Models.USER.UserModel", "User")
                        .WithMany("Address")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.UserModel", b =>
                {
                    b.HasOne("Joben_DAL.Models.USER.MISC.CivilStatusModel", "CivilStatus")
                        .WithMany()
                        .HasForeignKey("CivilStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Joben_DAL.Models.USER.MISC.GenderModel", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Joben_DAL.Models.USER.MISC.PositionModel", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CivilStatus");

                    b.Navigation("Gender");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Joben_DAL.Models.USER.UserModel", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
