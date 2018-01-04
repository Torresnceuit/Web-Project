﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyCV.Models;
using System;

namespace MyCV.Migrations
{
    [DbContext(typeof(MyCVContext))]
    [Migration("20171216014413_Projects")]
    partial class Projects
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCV.Models.Projects", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Languages");

                    b.Property<string>("Period");

                    b.Property<string>("ProjectName");

                    b.Property<string>("Technologies");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MyCV.Models.WorkExperience", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Job_Type");

                    b.Property<string>("Responsibilities");

                    b.Property<string>("Title");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("ID");

                    b.ToTable("WorkExperience");
                });
#pragma warning restore 612, 618
        }
    }
}
