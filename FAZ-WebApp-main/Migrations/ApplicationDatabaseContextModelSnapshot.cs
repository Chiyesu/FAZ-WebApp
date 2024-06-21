﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FAZ.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    partial class ApplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Data.Match", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MatchId"));

                    b.Property<int>("AssistantReferee1Id")
                        .HasColumnType("int");

                    b.Property<int>("AssistantReferee2Id")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DatePlayed")
                        .HasColumnType("date");

                    b.Property<string>("FinalResult")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GuestTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HostTeamId")
                        .HasColumnType("int");

                    b.Property<string>("News")
                        .HasColumnType("longtext");

                    b.Property<int>("RefereeId")
                        .HasColumnType("int");

                    b.HasKey("MatchId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MatchParticipation", b =>
                {
                    b.Property<int>("MatchParticipationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MatchParticipationId"));

                    b.Property<int>("Card")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DatePlayed")
                        .HasColumnType("date");

                    b.Property<int>("GoalScored")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MatchParticipationId");

                    b.ToTable("MatchParticipation");
                });

            modelBuilder.Entity("Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ShirtNumber")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartYear")
                        .HasColumnType("date");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Referee", b =>
                {
                    b.Property<int>("RefereeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RefereeId"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("RefereeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("RefereeId");

                    b.ToTable("Referees");
                });

            modelBuilder.Entity("Substitution", b =>
                {
                    b.Property<int>("SubstitutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SubstitutionId"));

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerInId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerOutId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time(6)");

                    b.HasKey("SubstitutionId");

                    b.ToTable("Substitutions");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TeamId"));

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("MainStadium")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
