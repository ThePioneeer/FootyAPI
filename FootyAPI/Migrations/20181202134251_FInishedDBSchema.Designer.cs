﻿// <auto-generated />
using System;
using FootyAPI.Entities.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FootyAPI.Migrations
{
    [DbContext(typeof(FootyDBContext))]
    [Migration("20181202134251_FInishedDBSchema")]
    partial class FInishedDBSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FootyAPI.Entities.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingTime");

                    b.Property<string>("BookingType");

                    b.Property<string>("Comments");

                    b.Property<int>("CompetitionId");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayHalf");

                    b.Property<string>("PlaySchedule");

                    b.Property<int>("PlayerId");

                    b.Property<string>("SentOff");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FootyAPI.Entities.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssistByPlayerId");

                    b.Property<int>("CompetitionId");

                    b.Property<int>("GoalHalf");

                    b.Property<string>("GoalSchedule");

                    b.Property<string>("GoalTime");

                    b.Property<string>("GoalType");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Goals");
                });

            modelBuilder.Entity("FootyAPI.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompetitionType");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Season");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("FootyAPI.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayScore");

                    b.Property<int>("AwayTeamId");

                    b.Property<int>("CompetitionId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("HomeScore");

                    b.Property<string>("PenaltyScore");

                    b.Property<int>("PlayerofTheMatch");

                    b.Property<string>("Result");

                    b.Property<int>("TeamId");

                    b.Property<int>("VenueId");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("FootyAPI.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Country");

                    b.Property<int>("Number");

                    b.Property<string>("PlayerName");

                    b.Property<int>("PositionId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FootyAPI.Models.PlayingPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName");

                    b.HasKey("Id");

                    b.ToTable("PlayingPositions");
                });

            modelBuilder.Entity("FootyAPI.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GoalsAgainst");

                    b.Property<int>("GoalsFor");

                    b.Property<string>("HomePage");

                    b.Property<int>("HomeVenueId");

                    b.Property<int>("MatchesDrawn");

                    b.Property<int>("MatchesPlayed");

                    b.Property<int>("MatchesWon");

                    b.Property<int>("MathcehsLost");

                    b.Property<string>("Name");

                    b.Property<int>("Points");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FootyAPI.Models.Venue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Venues");
                });
#pragma warning restore 612, 618
        }
    }
}
