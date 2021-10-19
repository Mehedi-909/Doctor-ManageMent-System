﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlinePrescription.Models;

namespace OnlinePrescription.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210823140247_p1")]
    partial class p1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlinePrescription.Models.DoctorAuth", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DoctorAuthTable");
                });

            modelBuilder.Entity("OnlinePrescription.Models.DoctorInfo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("qualification")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DoctorInfoTable");
                });

            modelBuilder.Entity("OnlinePrescription.Models.Medicine", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<string>("indication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MedicineTable");
                });

            modelBuilder.Entity("OnlinePrescription.Models.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<string>("mobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PatientTable");
                });

            modelBuilder.Entity("OnlinePrescription.Models.PrescribedMedicine", b =>
                {
                    b.Property<string>("medicineName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Prescriptionid")
                        .HasColumnType("int");

                    b.Property<bool>("afterEating")
                        .HasColumnType("bit");

                    b.Property<bool>("beforeEating")
                        .HasColumnType("bit");

                    b.Property<bool>("morning")
                        .HasColumnType("bit");

                    b.Property<bool>("night")
                        .HasColumnType("bit");

                    b.Property<bool>("noon")
                        .HasColumnType("bit");

                    b.Property<string>("numberOfDaysToTake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otherInfo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("medicineName");

                    b.HasIndex("Prescriptionid");

                    b.ToTable("PrescribedMedicine");
                });

            modelBuilder.Entity("OnlinePrescription.Models.Prescription", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("doctorId")
                        .HasColumnType("int");

                    b.Property<int>("patientId")
                        .HasColumnType("int");

                    b.Property<string>("suggestion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("PrescriptionTable");
                });

            modelBuilder.Entity("OnlinePrescription.Models.PrescribedMedicine", b =>
                {
                    b.HasOne("OnlinePrescription.Models.Prescription", null)
                        .WithMany("prescribedMedicines")
                        .HasForeignKey("Prescriptionid");
                });

            modelBuilder.Entity("OnlinePrescription.Models.Prescription", b =>
                {
                    b.Navigation("prescribedMedicines");
                });
#pragma warning restore 612, 618
        }
    }
}
