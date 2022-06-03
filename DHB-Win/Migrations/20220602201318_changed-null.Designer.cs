﻿// <auto-generated />
using System;
using DHB_Win.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DHB_Win.Migrations
{
    [DbContext(typeof(dhbwinContext))]
    [Migration("20220602201318_changed-null")]
    partial class changednull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DHB_Win.Models.AchievedAchievement", b =>
                {
                    b.Property<string>("Aaid")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AAID");

                    b.Property<string>("AchIdFk")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AchID_fk");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UidFk")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("UID_fk");

                    b.HasKey("Aaid")
                        .HasName("AAID_PK");

                    b.HasIndex("UidFk");

                    b.HasIndex(new[] { "AchIdFk" }, "AchievedAchievement_AchID_fk_uindex")
                        .IsUnique();

                    b.ToTable("AchievedAchievement", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.Achievement", b =>
                {
                    b.Property<string>("AchId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("AchID");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("char(500)")
                        .IsFixedLength();

                    b.Property<int?>("ExpPoints")
                        .HasColumnType("int");

                    b.Property<int?>("Reward")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.HasKey("AchId")
                        .HasName("Achievement_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("AchId"), false);

                    b.HasIndex(new[] { "AchId" }, "Achievement_AchID_uindex")
                        .IsUnique();

                    b.ToTable("Achievement", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.Bet", b =>
                {
                    b.Property<string>("BetId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BetID");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("char(500)")
                        .IsFixedLength();

                    b.Property<int?>("ExpPoints")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Reward")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("UidFk2")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("UID_fk2");

                    b.HasKey("BetId")
                        .HasName("Bet_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("BetId"), false);

                    b.HasIndex("UidFk2");

                    b.HasIndex(new[] { "BetId" }, "Bet_BetID_uindex")
                        .IsUnique();

                    b.ToTable("Bet", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.BetOption", b =>
                {
                    b.Property<string>("OptionsId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("OptionsID");

                    b.Property<string>("BetId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BetID");

                    b.Property<string>("Descpription")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("char(500)")
                        .IsFixedLength();

                    b.Property<int?>("QuoteValue")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.HasKey("OptionsId")
                        .HasName("BetOptions_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("OptionsId"), false);

                    b.HasIndex("BetId");

                    b.HasIndex(new[] { "OptionsId" }, "BetOptions_OptionsID_uindex")
                        .IsUnique();

                    b.ToTable("BetOptions", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.Job", b =>
                {
                    b.Property<string>("JobId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("JobID");

                    b.Property<DateTime?>("CreationDate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<int?>("ExpPoints")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ProviderId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ProviderID");

                    b.Property<int?>("Reward")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("char(50)")
                        .IsFixedLength();

                    b.Property<string>("WorkerId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("WorkerID");

                    b.HasKey("JobId")
                        .HasName("Job_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("JobId"), false);

                    b.HasIndex("ProviderId");

                    b.HasIndex("WorkerId");

                    b.HasIndex(new[] { "JobId" }, "Job_JobID_uindex")
                        .IsUnique();

                    b.ToTable("Job", "dhbwin");

                    b.HasComment("Create jobs with Betcoins");
                });

            modelBuilder.Entity("DHB_Win.Models.Placement", b =>
                {
                    b.Property<string>("UidFk")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("UID_fk");

                    b.Property<string>("PlacementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PlacementID");

                    b.Property<string>("BetIdFk")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BetID_fk");

                    b.Property<string>("OptionIdFk")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("OptionID_fk");

                    b.HasKey("UidFk", "PlacementId", "BetIdFk")
                        .HasName("Placement_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("UidFk", "PlacementId", "BetIdFk"), false);

                    b.HasIndex("BetIdFk");

                    b.HasIndex("OptionIdFk");

                    b.ToTable("Placement", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.Plz", b =>
                {
                    b.Property<string>("Plz1")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PLZ");

                    b.Property<string>("Ort")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("char(30)")
                        .IsFixedLength();

                    b.HasKey("Plz1")
                        .HasName("PLZ_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Plz1"), false);

                    b.HasIndex(new[] { "Plz1" }, "PLZ_PLZ_uindex")
                        .IsUnique();

                    b.ToTable("PLZ", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("char(500)")
                        .IsFixedLength();

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PlzFk")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("PLZ_fk");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PlzFk");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DHB_Win.Models.AchievedAchievement", b =>
                {
                    b.HasOne("DHB_Win.Models.Achievement", "AchIdFkNavigation")
                        .WithOne("AchievedAchievement")
                        .HasForeignKey("DHB_Win.Models.AchievedAchievement", "AchIdFk")
                        .IsRequired()
                        .HasConstraintName("AchievedAchievement_Achievement_AchID_fk");

                    b.HasOne("DHB_Win.Models.User", "UidFkNavigation")
                        .WithMany("AchievedAchievements")
                        .HasForeignKey("UidFk")
                        .IsRequired()
                        .HasConstraintName("User_AchievedAchievement___fk");

                    b.Navigation("AchIdFkNavigation");

                    b.Navigation("UidFkNavigation");
                });

            modelBuilder.Entity("DHB_Win.Models.Bet", b =>
                {
                    b.HasOne("DHB_Win.Models.User", "UidFk2Navigation")
                        .WithMany("Bets")
                        .HasForeignKey("UidFk2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("UID_fk2");

                    b.Navigation("UidFk2Navigation");
                });

            modelBuilder.Entity("DHB_Win.Models.BetOption", b =>
                {
                    b.HasOne("DHB_Win.Models.Bet", "Bet")
                        .WithMany("BetOptions")
                        .HasForeignKey("BetId")
                        .HasConstraintName("BetOptions_Bet_BetID_fk");

                    b.Navigation("Bet");
                });

            modelBuilder.Entity("DHB_Win.Models.Job", b =>
                {
                    b.HasOne("DHB_Win.Models.User", "Provider")
                        .WithMany("JobProviders")
                        .HasForeignKey("ProviderId")
                        .HasConstraintName("Job_User_UID_fk");

                    b.HasOne("DHB_Win.Models.User", "Worker")
                        .WithMany("JobWorkers")
                        .HasForeignKey("WorkerId")
                        .HasConstraintName("Job_worker_fk");

                    b.Navigation("Provider");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("DHB_Win.Models.Placement", b =>
                {
                    b.HasOne("DHB_Win.Models.Bet", "BetIdFkNavigation")
                        .WithMany("Placements")
                        .HasForeignKey("BetIdFk")
                        .IsRequired()
                        .HasConstraintName("Bet_fk");

                    b.HasOne("DHB_Win.Models.BetOption", "OptionIdFkNavigation")
                        .WithMany("Placements")
                        .HasForeignKey("OptionIdFk")
                        .HasConstraintName("Placement_BetOptions_OptionsID_fk");

                    b.HasOne("DHB_Win.Models.User", "UidFkNavigation")
                        .WithMany("Placements")
                        .HasForeignKey("UidFk")
                        .IsRequired()
                        .HasConstraintName("User_fk");

                    b.Navigation("BetIdFkNavigation");

                    b.Navigation("OptionIdFkNavigation");

                    b.Navigation("UidFkNavigation");
                });

            modelBuilder.Entity("DHB_Win.Models.User", b =>
                {
                    b.HasOne("DHB_Win.Models.Plz", "PlzFkNavigation")
                        .WithMany("Users")
                        .HasForeignKey("PlzFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("PLZ_fk");

                    b.Navigation("PlzFkNavigation");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DHB_Win.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DHB_Win.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DHB_Win.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DHB_Win.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DHB_Win.Models.Achievement", b =>
                {
                    b.Navigation("AchievedAchievement")
                        .IsRequired();
                });

            modelBuilder.Entity("DHB_Win.Models.Bet", b =>
                {
                    b.Navigation("BetOptions");

                    b.Navigation("Placements");
                });

            modelBuilder.Entity("DHB_Win.Models.BetOption", b =>
                {
                    b.Navigation("Placements");
                });

            modelBuilder.Entity("DHB_Win.Models.Plz", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DHB_Win.Models.User", b =>
                {
                    b.Navigation("AchievedAchievements");

                    b.Navigation("Bets");

                    b.Navigation("JobProviders");

                    b.Navigation("JobWorkers");

                    b.Navigation("Placements");
                });
#pragma warning restore 612, 618
        }
    }
}
