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
    [Migration("20220608074532_test")]
    partial class test
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
                    b.Property<int>("Aaid")
                        .HasColumnType("int")
                        .HasColumnName("AAID");

                    b.Property<int>("AchIdFk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
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
                    b.Property<int>("AchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AchID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AchId"), 1L, 1);

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
                    b.Property<int>("BetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BetID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BetId"), 1L, 1);

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

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BetId")
                        .HasName("Bet_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("BetId"), false);

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "BetId" }, "Bet_BetID_uindex")
                        .IsUnique();

                    b.ToTable("Bet", "dhbwin");
                });

            modelBuilder.Entity("DHB_Win.Models.BetOption", b =>
                {
                    b.Property<int>("OptionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OptionsID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OptionsId"), 1L, 1);

                    b.Property<int?>("BetId")
                        .HasColumnType("int")
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
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"), 1L, 1);

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

                    b.Property<int>("PlacementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PlacementID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlacementId"), 1L, 1);

                    b.Property<int>("BetIdFk")
                        .HasColumnType("int")
                        .HasColumnName("BetID_fk");

                    b.Property<int?>("OptionIdFk")
                        .HasColumnType("int")
                        .HasColumnName("OptionID_fk");

                    b.HasKey("UidFk", "PlacementId", "BetIdFk")
                        .HasName("Placement_pk");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("UidFk", "PlacementId", "BetIdFk"), false);

                    b.HasIndex("BetIdFk");

                    b.HasIndex("OptionIdFk");

                    b.ToTable("Placement", "dhbwin");
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
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
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

                    b.Property<string>("Plz")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("char(10)")
                        .IsFixedLength();

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadt")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<string>("Street")
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

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
                    b.HasOne("DHB_Win.Models.User", "User")
                        .WithMany("Bets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("UID_fk2");

                    b.Navigation("User");
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
