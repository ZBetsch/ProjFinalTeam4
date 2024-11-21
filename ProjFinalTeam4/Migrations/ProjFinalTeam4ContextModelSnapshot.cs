﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjFinalTeam4.Data;

#nullable disable

namespace ProjFinalTeam4.Migrations
{
    [DbContext(typeof(ProjFinalTeam4Context))]
    partial class ProjFinalTeam4ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjFinalTeam4.Models.Hobbies", b =>
                {
                    b.Property<int>("hobbiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("hobbiesId"));

                    b.Property<string>("hobbiesDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hobbiesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hobbiesResources")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("hobbiesStart")
                        .HasColumnType("int");

                    b.HasKey("hobbiesId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("ProjFinalTeam4.Models.Travel", b =>
                {
                    b.Property<int>("travelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("travelId"));

                    b.Property<int>("travelCost")
                        .HasColumnType("int");

                    b.Property<string>("travelCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("travelDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("travelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("travelId");

                    b.ToTable("Travel");
                });
#pragma warning restore 612, 618
        }
    }
}
