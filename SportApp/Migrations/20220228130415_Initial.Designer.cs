﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportApp.Models;

#nullable disable

namespace SportApp.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220228130415_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SportApp.Models.DietPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfDiet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DietPlan");
                });

            modelBuilder.Entity("SportApp.Models.Diseases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DiseaseDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("SportApp.Models.Entities.PersonalAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DietPlanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraningPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId");

                    b.HasIndex("TraningPlanId");

                    b.ToTable("PersonalAccounts");
                });

            modelBuilder.Entity("SportApp.Models.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PlanName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimingOfTraining")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeOfTraining")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPlans");
                });

            modelBuilder.Entity("SportApp.Models.TypeOfActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DurationOfActivity")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfTrainingsWeek")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("SportApp.Models.TypeOfFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountOfFoodPerDay")
                        .HasColumnType("int");

                    b.Property<float>("CountOfKcal")
                        .HasColumnType("real");

                    b.Property<string>("typeOfFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodType");
                });

            modelBuilder.Entity("SportApp.Models.UserLogIn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLogIn");
                });

            modelBuilder.Entity("SportApp.Models.UserRespondes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int>("DietPlanId")
                        .HasColumnType("int");

                    b.Property<int>("DiseasesId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrainingPlanId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfActivityId")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfFoodId")
                        .HasColumnType("int");

                    b.Property<int>("UserLogInId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DietPlanId")
                        .IsUnique();

                    b.HasIndex("DiseasesId")
                        .IsUnique();

                    b.HasIndex("TrainingPlanId")
                        .IsUnique();

                    b.HasIndex("TypeOfActivityId")
                        .IsUnique();

                    b.HasIndex("TypeOfFoodId")
                        .IsUnique();

                    b.HasIndex("UserLogInId")
                        .IsUnique();

                    b.ToTable("UserRespondes", (string)null);
                });

            modelBuilder.Entity("SportApp.Models.Entities.PersonalAccount", b =>
                {
                    b.HasOne("SportApp.Models.DietPlan", "DietPlan")
                        .WithMany()
                        .HasForeignKey("DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.TrainingPlan", "TraningPlan")
                        .WithMany()
                        .HasForeignKey("TraningPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");

                    b.Navigation("TraningPlan");
                });

            modelBuilder.Entity("SportApp.Models.UserRespondes", b =>
                {
                    b.HasOne("SportApp.Models.DietPlan", "DietPlan")
                        .WithOne("UserName")
                        .HasForeignKey("SportApp.Models.UserRespondes", "DietPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.Diseases", "Diseases")
                        .WithOne("UserName")
                        .HasForeignKey("SportApp.Models.UserRespondes", "DiseasesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.TrainingPlan", "TrainingPlan")
                        .WithOne("UserRespondes")
                        .HasForeignKey("SportApp.Models.UserRespondes", "TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.TypeOfActivity", "TypeOfActivity")
                        .WithOne("UserName")
                        .HasForeignKey("SportApp.Models.UserRespondes", "TypeOfActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.TypeOfFood", "TypeOfFood")
                        .WithOne("UserName")
                        .HasForeignKey("SportApp.Models.UserRespondes", "TypeOfFoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportApp.Models.UserLogIn", "UserLogIn")
                        .WithOne("UserName")
                        .HasForeignKey("SportApp.Models.UserRespondes", "UserLogInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");

                    b.Navigation("Diseases");

                    b.Navigation("TrainingPlan");

                    b.Navigation("TypeOfActivity");

                    b.Navigation("TypeOfFood");

                    b.Navigation("UserLogIn");
                });

            modelBuilder.Entity("SportApp.Models.DietPlan", b =>
                {
                    b.Navigation("UserName")
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.Models.Diseases", b =>
                {
                    b.Navigation("UserName")
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.Models.TrainingPlan", b =>
                {
                    b.Navigation("UserRespondes")
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.Models.TypeOfActivity", b =>
                {
                    b.Navigation("UserName")
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.Models.TypeOfFood", b =>
                {
                    b.Navigation("UserName")
                        .IsRequired();
                });

            modelBuilder.Entity("SportApp.Models.UserLogIn", b =>
                {
                    b.Navigation("UserName")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}