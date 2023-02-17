﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS.Data;

#nullable disable

namespace PMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PMS.Model.Milestone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("PMS.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractSignDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LcOppeningDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfMilestones")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannedEndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PlannedStartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("PMS.Model.SubTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TasksId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TasksId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("PMS.Model.Tasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ActualFinish")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ActualStart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Completion")
                        .HasColumnType("int");

                    b.Property<int>("MilestoneId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannedFinish")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PlannedStart")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ScheduleHealth")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MilestoneId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("PMS.Model.Milestone", b =>
                {
                    b.HasOne("PMS.Model.Project", null)
                        .WithMany("Milestones")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMS.Model.SubTask", b =>
                {
                    b.HasOne("PMS.Model.Tasks", null)
                        .WithMany("SubTasks")
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMS.Model.Tasks", b =>
                {
                    b.HasOne("PMS.Model.Milestone", null)
                        .WithMany("Tasks")
                        .HasForeignKey("MilestoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PMS.Model.Milestone", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("PMS.Model.Project", b =>
                {
                    b.Navigation("Milestones");
                });

            modelBuilder.Entity("PMS.Model.Tasks", b =>
                {
                    b.Navigation("SubTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
