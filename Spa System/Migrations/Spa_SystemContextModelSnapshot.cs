﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spa_System.Models;

namespace Spa_System.Migrations
{
    [DbContext(typeof(Spa_SystemContext))]
    partial class Spa_SystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Spa_System.Models.Beautician", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Beautician");
                });

            modelBuilder.Entity("Spa_System.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("ContactNumber")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Spa_System.Models.Package", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackageName");

                    b.Property<int>("Price");

                    b.HasKey("ID");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Spa_System.Models.PackageAppointment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppointmentDate");

                    b.Property<DateTime?>("AppointmentTime");

                    b.Property<int?>("BeauticianID");

                    b.Property<int>("CustomerID");

                    b.Property<int>("PackageID");

                    b.Property<string>("Status");

                    b.Property<int>("discountGiven");

                    b.HasKey("ID");

                    b.HasIndex("BeauticianID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("PackageID");

                    b.ToTable("packageAppointment");
                });

            modelBuilder.Entity("Spa_System.Models.PackageTreatment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PackageID");

                    b.Property<int>("TreatmentID");

                    b.HasKey("ID");

                    b.HasIndex("PackageID");

                    b.HasIndex("TreatmentID");

                    b.ToTable("PackageTreatment");
                });

            modelBuilder.Entity("Spa_System.Models.Treatment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("Spa_System.Models.PackageAppointment", b =>
                {
                    b.HasOne("Spa_System.Models.Beautician", "Beautician")
                        .WithMany("BeauticianAppointments")
                        .HasForeignKey("BeauticianID");

                    b.HasOne("Spa_System.Models.Customer", "Customer")
                        .WithMany("CustomerAppointments")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Spa_System.Models.Package", "CustomerPackage")
                        .WithMany("CustomerPackages")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Spa_System.Models.PackageTreatment", b =>
                {
                    b.HasOne("Spa_System.Models.Package", "Package")
                        .WithMany("PackageTreatments")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Spa_System.Models.Treatment", "Treatment")
                        .WithMany("PackageTreatments")
                        .HasForeignKey("TreatmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
