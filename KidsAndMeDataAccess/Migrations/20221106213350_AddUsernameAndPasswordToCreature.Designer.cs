// <auto-generated />
using System;
using KidsAndMeDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KidsAndMeDataAccess.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20221106213350_AddUsernameAndPasswordToCreature")]
    partial class AddUsernameAndPasswordToCreature
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KidsAndMeCommon.Entities.Baby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatureType")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Babies");
                });

            modelBuilder.Entity("KidsAndMeCommon.Entities.BabyFoodAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChildReaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumptionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("EatingDuration")
                        .HasColumnType("float");

                    b.Property<int>("FoodSupply")
                        .HasColumnType("int");

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("BabyFoodAttempts");
                });

            modelBuilder.Entity("KidsAndMeCommon.Entities.BathAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BathAttempts");
                });

            modelBuilder.Entity("KidsAndMeCommon.Entities.MomFoodAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChildReaction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumptionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("EatingDuration")
                        .HasColumnType("float");

                    b.Property<int>("FoodSupply")
                        .HasColumnType("int");

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MomFoodAttempts");
                });

            modelBuilder.Entity("KidsAndMeCommon.Entities.SleepAttempt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SleepAttempts");
                });

            modelBuilder.Entity("KidsAndMeCommon.Entities.SleepReminder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SleepReminders");
                });
#pragma warning restore 612, 618
        }
    }
}
