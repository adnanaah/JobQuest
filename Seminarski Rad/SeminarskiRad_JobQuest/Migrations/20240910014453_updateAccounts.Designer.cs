﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarskiRad_JobQuest.Data.dbContext;

#nullable disable

namespace SeminarskiRad_JobQuest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240910014453_updateAccounts")]
    partial class updateAccounts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("KorisnickiRacunSequence");

            modelBuilder.Entity("AplikantOglas", b =>
                {
                    b.Property<int>("AplikantID")
                        .HasColumnType("int");

                    b.Property<int>("SpaseniOglasiID")
                        .HasColumnType("int");

                    b.HasKey("AplikantID", "SpaseniOglasiID");

                    b.HasIndex("SpaseniOglasiID");

                    b.ToTable("AplikantOglas");
                });

            modelBuilder.Entity("AplikantSkill", b =>
                {
                    b.Property<int>("AplikantID")
                        .HasColumnType("int");

                    b.Property<int>("SkillsID")
                        .HasColumnType("int");

                    b.HasKey("AplikantID", "SkillsID");

                    b.HasIndex("SkillsID");

                    b.ToTable("AplikantSkill");
                });

            modelBuilder.Entity("AplikantZaposlenje", b =>
                {
                    b.Property<int>("AplikantID")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenjaID")
                        .HasColumnType("int");

                    b.HasKey("AplikantID", "ZaposlenjaID");

                    b.HasIndex("ZaposlenjaID");

                    b.ToTable("AplikantZaposlenje");
                });

            modelBuilder.Entity("KomentarKompanija", b =>
                {
                    b.Property<int>("KomentariID")
                        .HasColumnType("int");

                    b.Property<int>("KompanijaID")
                        .HasColumnType("int");

                    b.HasKey("KomentariID", "KompanijaID");

                    b.HasIndex("KompanijaID");

                    b.ToTable("KomentarKompanija");
                });

            modelBuilder.Entity("OglasSkill", b =>
                {
                    b.Property<int>("OglasID")
                        .HasColumnType("int");

                    b.Property<int>("RequiredSkillsID")
                        .HasColumnType("int");

                    b.HasKey("OglasID", "RequiredSkillsID");

                    b.HasIndex("RequiredSkillsID");

                    b.ToTable("OglasSkill");
                });

            modelBuilder.Entity("PoslodavacZaposlenje", b =>
                {
                    b.Property<int>("PoslodavacID")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenjaID")
                        .HasColumnType("int");

                    b.HasKey("PoslodavacID", "ZaposlenjaID");

                    b.HasIndex("ZaposlenjaID");

                    b.ToTable("PoslodavacZaposlenje");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Adresa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BrojUlice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GradID");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Aplikacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AplikantID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Files")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("OglasID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Prihvacena")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("AplikantID");

                    b.HasIndex("OglasID");

                    b.ToTable("Aplikacija");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Certifikat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AplikantID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Files")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AplikantID");

                    b.ToTable("Certifikat");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Drzava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.KategorijaPosla", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KategorijaPosla");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Komentar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumUnosa")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Kompanija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AdresaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumOsnivanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeCount")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AdresaID");

                    b.ToTable("Kompanija");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.KorisnickiRacun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [KorisnickiRacunSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("ID"));

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserProfilePicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VerifiedAccount")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("DrzavaID");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.NivoIskustva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NivoIskustva");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Oglas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaPoslaID")
                        .HasColumnType("int");

                    b.Property<int>("NivoIskustvaID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoslodavacID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TipPoslaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GradID");

                    b.HasIndex("KategorijaPoslaID");

                    b.HasIndex("NivoIskustvaID");

                    b.HasIndex("PoslodavacID");

                    b.HasIndex("TipPoslaID");

                    b.ToTable("Oglas");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.ReccLetter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AplikantID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PoslodavacID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AplikantID");

                    b.HasIndex("PoslodavacID");

                    b.ToTable("ReccLetter");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Skill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.TipPosla", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipPosla");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Zaposlenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Current")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImeKompanije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KompanijaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("KompanijaID");

                    b.ToTable("Zaposlenje");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Administrator", b =>
                {
                    b.HasBaseType("SeminarskiRad_JobQuest.Data.Models.KorisnickiRacun");

                    b.Property<bool>("UserVerification")
                        .HasColumnType("bit");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Aplikant", b =>
                {
                    b.HasBaseType("SeminarskiRad_JobQuest.Data.Models.KorisnickiRacun");

                    b.Property<byte[]>("CV")
                        .HasColumnType("varbinary(max)");

                    b.ToTable("Aplikant");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Poslodavac", b =>
                {
                    b.HasBaseType("SeminarskiRad_JobQuest.Data.Models.KorisnickiRacun");

                    b.Property<int>("KompanijaID")
                        .HasColumnType("int");

                    b.HasIndex("KompanijaID");

                    b.ToTable("Poslodavac");
                });

            modelBuilder.Entity("AplikantOglas", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Oglas", null)
                        .WithMany()
                        .HasForeignKey("SpaseniOglasiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantSkill", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AplikantZaposlenje", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", null)
                        .WithMany()
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Zaposlenje", null)
                        .WithMany()
                        .HasForeignKey("ZaposlenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KomentarKompanija", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Komentar", null)
                        .WithMany()
                        .HasForeignKey("KomentariID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Kompanija", null)
                        .WithMany()
                        .HasForeignKey("KompanijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OglasSkill", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Oglas", null)
                        .WithMany()
                        .HasForeignKey("OglasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("RequiredSkillsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PoslodavacZaposlenje", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Poslodavac", null)
                        .WithMany()
                        .HasForeignKey("PoslodavacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Zaposlenje", null)
                        .WithMany()
                        .HasForeignKey("ZaposlenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Adresa", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Aplikacija", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", "Aplikant")
                        .WithMany()
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Oglas", "Oglas")
                        .WithMany()
                        .HasForeignKey("OglasID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Aplikant");

                    b.Navigation("Oglas");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Certifikat", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", null)
                        .WithMany("Certifikati")
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Grad", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Kompanija", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.KorisnickiRacun", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Oglas", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.KategorijaPosla", "KategorijaPosla")
                        .WithMany()
                        .HasForeignKey("KategorijaPoslaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.NivoIskustva", "NivoIskustva")
                        .WithMany()
                        .HasForeignKey("NivoIskustvaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Poslodavac", "Poslodavac")
                        .WithMany()
                        .HasForeignKey("PoslodavacID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.TipPosla", "TipPosla")
                        .WithMany()
                        .HasForeignKey("TipPoslaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("KategorijaPosla");

                    b.Navigation("NivoIskustva");

                    b.Navigation("Poslodavac");

                    b.Navigation("TipPosla");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.ReccLetter", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Aplikant", "Aplikant")
                        .WithMany()
                        .HasForeignKey("AplikantID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Poslodavac", "Poslodavac")
                        .WithMany()
                        .HasForeignKey("PoslodavacID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Aplikant");

                    b.Navigation("Poslodavac");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Zaposlenje", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Kompanija", "Kompanija")
                        .WithMany()
                        .HasForeignKey("KompanijaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kompanija");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Poslodavac", b =>
                {
                    b.HasOne("SeminarskiRad_JobQuest.Data.Models.Kompanija", "Kompanija")
                        .WithMany()
                        .HasForeignKey("KompanijaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Kompanija");
                });

            modelBuilder.Entity("SeminarskiRad_JobQuest.Data.Models.Aplikant", b =>
                {
                    b.Navigation("Certifikati");
                });
#pragma warning restore 612, 618
        }
    }
}