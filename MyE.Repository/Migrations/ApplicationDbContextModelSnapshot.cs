﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyE.Repository.Context;

namespace MyE.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyE.Entity.FinalReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("MachineReviewId");

                    b.Property<int>("MembershipId");

                    b.Property<DateTime>("ReportDate");

                    b.HasKey("Id");

                    b.HasIndex("MachineReviewId");

                    b.ToTable("FinalReports");
                });

            modelBuilder.Entity("MyE.Entity.MachineReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EngineerId");

                    b.Property<int>("OrderId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MachineReviews");
                });

            modelBuilder.Entity("MyE.Entity.MedicalEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Name");

                    b.Property<string>("StateDescription");

                    b.HasKey("Id");

                    b.ToTable("MedicalEquipments");
                });

            modelBuilder.Entity("MyE.Entity.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.Property<int>("QuantityEngineers");

                    b.HasKey("Id");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("MyE.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("MedicalEquipamentId");

                    b.Property<int?>("MedicalEquipmentId");

                    b.Property<int>("Priority");

                    b.Property<int>("UserId");

                    b.Property<string>("description");

                    b.HasKey("Id");

                    b.HasIndex("MedicalEquipmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyE.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameRole");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MyE.Entity.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AgreedDate");

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<int>("OrderId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("MyE.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<int>("IdRole");

                    b.Property<string>("Name");

                    b.Property<string>("Numdoc");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<int?>("RoleId");

                    b.Property<string>("Tipodoc");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyE.Entity.FinalReport", b =>
                {
                    b.HasOne("MyE.Entity.MachineReview")
                        .WithMany("FinalReports")
                        .HasForeignKey("MachineReviewId");
                });

            modelBuilder.Entity("MyE.Entity.MachineReview", b =>
                {
                    b.HasOne("MyE.Entity.User")
                        .WithMany("MachineReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyE.Entity.Order", b =>
                {
                    b.HasOne("MyE.Entity.MedicalEquipment")
                        .WithMany("Orders")
                        .HasForeignKey("MedicalEquipmentId");

                    b.HasOne("MyE.Entity.User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyE.Entity.Schedule", b =>
                {
                    b.HasOne("MyE.Entity.Order")
                        .WithMany("Schedules")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyE.Entity.User")
                        .WithMany("Schedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyE.Entity.User", b =>
                {
                    b.HasOne("MyE.Entity.Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
