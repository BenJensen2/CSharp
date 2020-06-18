﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wedding_Planner.Models;

namespace Wedding_Planner.Migrations
{
    [DbContext(typeof(WeddingContext))]
    [Migration("20200616212512_RSVPUser")]
    partial class RSVPUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Wedding_Planner.Models.RSVP", b =>
                {
                    b.Property<int>("RSVPId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.Property<int>("WeddingId");

                    b.HasKey("RSVPId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeddingId");

                    b.ToTable("RSVPs");
                });

            modelBuilder.Entity("Wedding_Planner.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wedding_Planner.Models.Wedding", b =>
                {
                    b.Property<int>("WeddingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("PlannerUserId");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Wedder1")
                        .IsRequired();

                    b.Property<string>("Wedder2")
                        .IsRequired();

                    b.HasKey("WeddingId");

                    b.HasIndex("PlannerUserId");

                    b.ToTable("Weddings");
                });

            modelBuilder.Entity("Wedding_Planner.Models.RSVP", b =>
                {
                    b.HasOne("Wedding_Planner.Models.User")
                        .WithMany("RSVPs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Wedding_Planner.Models.Wedding", "Wedding")
                        .WithMany("GuestList")
                        .HasForeignKey("WeddingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Wedding_Planner.Models.Wedding", b =>
                {
                    b.HasOne("Wedding_Planner.Models.User", "Planner")
                        .WithMany("WeddingsPlanned")
                        .HasForeignKey("PlannerUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
