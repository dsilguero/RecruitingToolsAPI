﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitingToolsAPI.Data;

#nullable disable

namespace RecruitingToolsAPI.Migrations
{
    [DbContext(typeof(RecruitingToolsDbContext))]
    [Migration("20231105095427_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecruitingToolsAPI.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedInUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.CandidateSelectionProcess", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("SelectionProcessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CandidateIntroductionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CandidateStatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CandidateId", "SelectionProcessId");

                    b.HasIndex("CandidateStatusId");

                    b.HasIndex("SelectionProcessId");

                    b.ToTable("CandidateSelectionProcess");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.CandidateStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CandidateStatuses");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("DocumentId");

                    b.HasIndex("CandidateId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.Recruiter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recruiters");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.RecruiterSelectionProcess", b =>
                {
                    b.Property<int>("RecruiterId")
                        .HasColumnType("int");

                    b.Property<int>("SelectionProcessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RecruiterId", "SelectionProcessId");

                    b.HasIndex("SelectionProcessId");

                    b.ToTable("RecruiterSelectionProcess");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.SelectionProcess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("SelectionProcesses");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.SelectionProcessStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SelectionProcessStatuses");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.CandidateSelectionProcess", b =>
                {
                    b.HasOne("RecruitingToolsAPI.Models.Candidate", "Candidate")
                        .WithMany("SelectionProcesses")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitingToolsAPI.Models.CandidateStatus", "CandidateStatus")
                        .WithMany("Candidates")
                        .HasForeignKey("CandidateStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitingToolsAPI.Models.SelectionProcess", "SelectionProcess")
                        .WithMany("Candidates")
                        .HasForeignKey("SelectionProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("CandidateStatus");

                    b.Navigation("SelectionProcess");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.Document", b =>
                {
                    b.HasOne("RecruitingToolsAPI.Models.Candidate", "Candidate")
                        .WithMany("Documents")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.RecruiterSelectionProcess", b =>
                {
                    b.HasOne("RecruitingToolsAPI.Models.Recruiter", "Recruiter")
                        .WithMany("ManagedProcesses")
                        .HasForeignKey("RecruiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitingToolsAPI.Models.SelectionProcess", "SelectionProcess")
                        .WithMany("Recruiters")
                        .HasForeignKey("SelectionProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recruiter");

                    b.Navigation("SelectionProcess");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.SelectionProcess", b =>
                {
                    b.HasOne("RecruitingToolsAPI.Models.SelectionProcessStatus", "Status")
                        .WithMany("SelectionProcesses")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.Candidate", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("SelectionProcesses");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.CandidateStatus", b =>
                {
                    b.Navigation("Candidates");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.Recruiter", b =>
                {
                    b.Navigation("ManagedProcesses");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.SelectionProcess", b =>
                {
                    b.Navigation("Candidates");

                    b.Navigation("Recruiters");
                });

            modelBuilder.Entity("RecruitingToolsAPI.Models.SelectionProcessStatus", b =>
                {
                    b.Navigation("SelectionProcesses");
                });
#pragma warning restore 612, 618
        }
    }
}
