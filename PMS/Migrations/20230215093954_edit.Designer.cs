﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PMS.Data;

#nullable disable

namespace PMS.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230215093954_edit")]
    partial class edit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PMS.Model.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("PMS.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PMS.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PMS.Model.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Roll")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

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

                    b.Property<int>("BudgetId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ContractSignDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LcOppeningDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("NumberOfMilestones")
                        .HasColumnType("int");

                    b.Property<DateTime>("PlannedEndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PlannedStartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SolutionsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId")
                        .IsUnique();

                    b.HasIndex("ClientId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SolutionsId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("PMS.Model.Solutions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SubSolution")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Solutions");
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

            modelBuilder.Entity("PMS.Model.Employee", b =>
                {
                    b.HasOne("PMS.Model.Member", "Member")
                        .WithMany("Employees")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("PMS.Model.Milestone", b =>
                {
                    b.HasOne("PMS.Model.Project", "Project")
                        .WithMany("Milestones")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("PMS.Model.Project", b =>
                {
                    b.HasOne("PMS.Model.Budget", "Budget")
                        .WithOne("Project")
                        .HasForeignKey("PMS.Model.Project", "BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS.Model.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PMS.Model.Solutions", "Solutions")
                        .WithMany("Projects")
                        .HasForeignKey("SolutionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");

                    b.Navigation("Client");

                    b.Navigation("Employee");

                    b.Navigation("Solutions");
                });

            modelBuilder.Entity("PMS.Model.Tasks", b =>
                {
                    b.HasOne("PMS.Model.Milestone", "Milestone")
                        .WithMany("Tasks")
                        .HasForeignKey("MilestoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Milestone");
                });

            modelBuilder.Entity("PMS.Model.Budget", b =>
                {
                    b.Navigation("Project")
                        .IsRequired();
                });

            modelBuilder.Entity("PMS.Model.Client", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("PMS.Model.Member", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("PMS.Model.Milestone", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("PMS.Model.Project", b =>
                {
                    b.Navigation("Milestones");
                });

            modelBuilder.Entity("PMS.Model.Solutions", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}