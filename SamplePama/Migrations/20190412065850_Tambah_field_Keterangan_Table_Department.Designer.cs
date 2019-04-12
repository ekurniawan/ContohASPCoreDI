﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamplePama.Models;

namespace SamplePama.Migrations
{
    [DbContext(typeof(PamaDataContext))]
    [Migration("20190412065850_Tambah_field_Keterangan_Table_Department")]
    partial class Tambah_field_Keterangan_Table_Department
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SamplePama.Models.Boss", b =>
                {
                    b.Property<int>("BossID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alamat");

                    b.Property<string>("Nama");

                    b.HasKey("BossID");

                    b.ToTable("Boss");
                });

            modelBuilder.Entity("SamplePama.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Keterangan");

                    b.Property<string>("NamaDept");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SamplePama.Models.Pegawai", b =>
                {
                    b.Property<int>("PegawaiID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PegawaiID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Pegawai");
                });

            modelBuilder.Entity("SamplePama.Models.Pegawai", b =>
                {
                    b.HasOne("SamplePama.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
