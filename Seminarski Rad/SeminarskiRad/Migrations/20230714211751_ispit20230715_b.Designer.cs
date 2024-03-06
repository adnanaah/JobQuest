﻿// <auto-generated />
using System;
using FIT_Api_Examples.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FIT_Api_Examples.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230714211751_ispit20230715_b")]
    partial class ispit20230715_b
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Controllers.Ispit20220924Controller+Destinacija2VM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AkcijaPoruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CijenaDolar")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoDrzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisPonude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelFirmaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TravelFirmaID");

                    b.ToTable("DestinacijaVM20220924");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Controllers.Ispit20220924Controller+TravelFirma", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TravelFirma20220924");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Controllers.Ispit20230624Controller+Ispit20230624PosaljiZapis", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("BrojIndeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinacijaDrzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gosti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OznakaSoba")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Vrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ispit20230624PosaljiZapis");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("employee_age")
                        .HasColumnType("int");

                    b.Property<string>("employee_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("employee_salary")
                        .HasColumnType("real");

                    b.Property<string>("profile_image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20210601Posalji", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicniBrojKupca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Upit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ispit20210601Posalji");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20210702Posalji", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumVrijeme")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ispit20210702Posalji");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20230715Destinacija", b =>
                {
                    b.Property<int>("Ispit20230715DestinacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ispit20230715DestinacijaID"), 1L, 1);

                    b.Property<string>("AkcijaPoruka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoDrzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpisPonude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravelFirmaID")
                        .HasColumnType("int");

                    b.HasKey("Ispit20230715DestinacijaID");

                    b.HasIndex("TravelFirmaID");

                    b.ToTable("Ispit20230715Destinacija");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20230715PlaniranoPutovanje", b =>
                {
                    b.Property<int>("Ispit20230715PlaniranoPutovanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ispit20230715PlaniranoPutovanjeID"), 1L, 1);

                    b.Property<int>("BrojSlobodnihMjesta")
                        .HasColumnType("int");

                    b.Property<double>("CijenaKM")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumPolaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPovratka")
                        .HasColumnType("datetime2");

                    b.Property<string>("HotelOpis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ispit20230715DestinacijaID")
                        .HasColumnType("int");

                    b.Property<string>("VrstaPrevoza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ispit20230715PlaniranoPutovanjeID");

                    b.HasIndex("Ispit20230715DestinacijaID");

                    b.ToTable("Ispit20230715PlaniranoPutovanje");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.ProjectTask", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employee_id")
                        .HasColumnType("int");

                    b.Property<float?>("original_estimated_hours")
                        .HasColumnType("real");

                    b.Property<int>("percent_completed")
                        .HasColumnType("int");

                    b.Property<int>("project_id")
                        .HasColumnType("int");

                    b.Property<float?>("spent_hours")
                        .HasColumnType("real");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("employee_id");

                    b.HasIndex("project_id");

                    b.ToTable("ProjectTask");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.TimeTracking", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_time")
                        .HasColumnType("datetime2");

                    b.Property<int>("project_task_id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("spent_time")
                        .HasColumnType("time");

                    b.Property<DateTime>("start_time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("project_task_id");

                    b.ToTable("TimeTracking");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("drzava_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("drzava_id");

                    b.ToTable("Opstina");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("broj_indeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datum_rodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("opstina_rodjenja_id")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_studenta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("opstina_rodjenja_id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumIspita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PredmetID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PredmetID");

                    b.ToTable("Ispit");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Predmet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<float>("ECTS")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Predmet");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumPrijave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IspitID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PrijavaIspita");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Controllers.Ispit20220924Controller+Destinacija2VM", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Controllers.Ispit20220924Controller+TravelFirma", "TravelFirma")
                        .WithMany()
                        .HasForeignKey("TravelFirmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelFirma");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20230715Destinacija", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Controllers.Ispit20220924Controller+TravelFirma", "TravelFirma")
                        .WithMany()
                        .HasForeignKey("TravelFirmaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelFirma");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.Ispit20230715PlaniranoPutovanje", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Models.Ispit20230715Destinacija", "Ispit20230715Destinacija")
                        .WithMany()
                        .HasForeignKey("Ispit20230715DestinacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ispit20230715Destinacija");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.ProjectTask", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FIT_Api_Examples.Modul1.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("project_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("project");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul1.Models.TimeTracking", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul1.Models.ProjectTask", "project_task")
                        .WithMany()
                        .HasForeignKey("project_task_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("project_task");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Opstina", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzava_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul2.Models.Student", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul2.Models.Opstina", "opstina_rodjenja")
                        .WithMany()
                        .HasForeignKey("opstina_rodjenja_id");

                    b.Navigation("opstina_rodjenja");
                });

            modelBuilder.Entity("FIT_Api_Examples.Modul3.Models.Ispit", b =>
                {
                    b.HasOne("FIT_Api_Examples.Modul3.Models.Predmet", "predmet")
                        .WithMany()
                        .HasForeignKey("PredmetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("predmet");
                });
#pragma warning restore 612, 618
        }
    }
}
