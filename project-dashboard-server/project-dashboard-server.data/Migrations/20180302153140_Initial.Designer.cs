﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SecuringAngularApps.Data;
using System;

namespace SecuringAngularApps.Data.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20180302153140_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SecuringAngularApps.Model.Milestone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MilestoneStatusId");

                    b.Property<string>("Name");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Milestones");
                });

            modelBuilder.Entity("SecuringAngularApps.Model.MilestoneStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MilestoneStatuses");
                });

            modelBuilder.Entity("SecuringAngularApps.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("SecuringAngularApps.Model.UserPermission", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("ProjectId");

                    b.Property<string>("UserProfileId");

                    b.Property<string>("Value");

                    b.HasKey("Id", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("SecuringAngularApps.Model.UserProfile", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("SecuringAngularApps.Model.Milestone", b =>
                {
                    b.HasOne("SecuringAngularApps.Model.Project")
                        .WithMany("Milestones")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SecuringAngularApps.Model.UserPermission", b =>
                {
                    b.HasOne("SecuringAngularApps.Model.Project")
                        .WithMany("UserPermissions")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SecuringAngularApps.Model.UserProfile")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserProfileId");
                });
#pragma warning restore 612, 618
        }
    }
}