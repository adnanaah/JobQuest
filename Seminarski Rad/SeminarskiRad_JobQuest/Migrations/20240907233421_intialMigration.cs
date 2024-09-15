using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiRad_JobQuest.Migrations
{
    /// <inheritdoc />
    public partial class intialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "KorisnickiRacunSequence");

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KategorijaPosla",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaPosla", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumUnosa = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NivoIskustva",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivoIskustva", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TipPosla",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipPosla", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KorisnickiRacunSequence]"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    UserVerification = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Administrator_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Aplikant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KorisnickiRacunSequence]"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    CV = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplikant", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Aplikant_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AplikantSkill",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    SkillsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantSkill", x => new { x.AplikantID, x.SkillsID });
                    table.ForeignKey(
                        name: "FK_AplikantSkill_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantSkill_Skill_SkillsID",
                        column: x => x.SkillsID,
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certifikat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Files = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AplikantID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifikat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Certifikat_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    Ulica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojUlice = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Adresa_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Kompanija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumOsnivanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false),
                    AdresaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kompanija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Kompanija_Adresa_AdresaID",
                        column: x => x.AdresaID,
                        principalTable: "Adresa",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "KomentarKompanija",
                columns: table => new
                {
                    KomentariID = table.Column<int>(type: "int", nullable: false),
                    KompanijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomentarKompanija", x => new { x.KomentariID, x.KompanijaID });
                    table.ForeignKey(
                        name: "FK_KomentarKompanija_Komentar_KomentariID",
                        column: x => x.KomentariID,
                        principalTable: "Komentar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KomentarKompanija_Kompanija_KompanijaID",
                        column: x => x.KompanijaID,
                        principalTable: "Kompanija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Poslodavac",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [KorisnickiRacunSequence]"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    KompanijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poslodavac", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poslodavac_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Poslodavac_Kompanija_KompanijaID",
                        column: x => x.KompanijaID,
                        principalTable: "Kompanija",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenje",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KompanijaID = table.Column<int>(type: "int", nullable: false),
                    ImeKompanije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Current = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zaposlenje_Kompanija_KompanijaID",
                        column: x => x.KompanijaID,
                        principalTable: "Kompanija",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Oglas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoslodavacID = table.Column<int>(type: "int", nullable: false),
                    KategorijaPoslaID = table.Column<int>(type: "int", nullable: false),
                    TipPoslaID = table.Column<int>(type: "int", nullable: false),
                    NivoIskustvaID = table.Column<int>(type: "int", nullable: false),
                    GradID = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oglas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Oglas_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Oglas_KategorijaPosla_KategorijaPoslaID",
                        column: x => x.KategorijaPoslaID,
                        principalTable: "KategorijaPosla",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Oglas_NivoIskustva_NivoIskustvaID",
                        column: x => x.NivoIskustvaID,
                        principalTable: "NivoIskustva",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Oglas_Poslodavac_PoslodavacID",
                        column: x => x.PoslodavacID,
                        principalTable: "Poslodavac",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Oglas_TipPosla_TipPoslaID",
                        column: x => x.TipPoslaID,
                        principalTable: "TipPosla",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ReccLetter",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PoslodavacID = table.Column<int>(type: "int", nullable: false),
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReccLetter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReccLetter_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ReccLetter_Poslodavac_PoslodavacID",
                        column: x => x.PoslodavacID,
                        principalTable: "Poslodavac",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AplikantZaposlenje",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    ZaposlenjaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantZaposlenje", x => new { x.AplikantID, x.ZaposlenjaID });
                    table.ForeignKey(
                        name: "FK_AplikantZaposlenje_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantZaposlenje_Zaposlenje_ZaposlenjaID",
                        column: x => x.ZaposlenjaID,
                        principalTable: "Zaposlenje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoslodavacZaposlenje",
                columns: table => new
                {
                    PoslodavacID = table.Column<int>(type: "int", nullable: false),
                    ZaposlenjaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslodavacZaposlenje", x => new { x.PoslodavacID, x.ZaposlenjaID });
                    table.ForeignKey(
                        name: "FK_PoslodavacZaposlenje_Poslodavac_PoslodavacID",
                        column: x => x.PoslodavacID,
                        principalTable: "Poslodavac",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoslodavacZaposlenje_Zaposlenje_ZaposlenjaID",
                        column: x => x.ZaposlenjaID,
                        principalTable: "Zaposlenje",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aplikacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OglasID = table.Column<int>(type: "int", nullable: false),
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    Files = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prihvacena = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aplikacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Aplikacija_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Aplikacija_Oglas_OglasID",
                        column: x => x.OglasID,
                        principalTable: "Oglas",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AplikantOglas",
                columns: table => new
                {
                    AplikantID = table.Column<int>(type: "int", nullable: false),
                    SpaseniOglasiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AplikantOglas", x => new { x.AplikantID, x.SpaseniOglasiID });
                    table.ForeignKey(
                        name: "FK_AplikantOglas_Aplikant_AplikantID",
                        column: x => x.AplikantID,
                        principalTable: "Aplikant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AplikantOglas_Oglas_SpaseniOglasiID",
                        column: x => x.SpaseniOglasiID,
                        principalTable: "Oglas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OglasSkill",
                columns: table => new
                {
                    OglasID = table.Column<int>(type: "int", nullable: false),
                    RequiredSkillsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OglasSkill", x => new { x.OglasID, x.RequiredSkillsID });
                    table.ForeignKey(
                        name: "FK_OglasSkill_Oglas_OglasID",
                        column: x => x.OglasID,
                        principalTable: "Oglas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OglasSkill_Skill_RequiredSkillsID",
                        column: x => x.RequiredSkillsID,
                        principalTable: "Skill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_DrzavaID",
                table: "Administrator",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresa_GradID",
                table: "Adresa",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Aplikacija_AplikantID",
                table: "Aplikacija",
                column: "AplikantID");

            migrationBuilder.CreateIndex(
                name: "IX_Aplikacija_OglasID",
                table: "Aplikacija",
                column: "OglasID");

            migrationBuilder.CreateIndex(
                name: "IX_Aplikant_DrzavaID",
                table: "Aplikant",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantOglas_SpaseniOglasiID",
                table: "AplikantOglas",
                column: "SpaseniOglasiID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantSkill_SkillsID",
                table: "AplikantSkill",
                column: "SkillsID");

            migrationBuilder.CreateIndex(
                name: "IX_AplikantZaposlenje_ZaposlenjaID",
                table: "AplikantZaposlenje",
                column: "ZaposlenjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Certifikat_AplikantID",
                table: "Certifikat",
                column: "AplikantID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_KomentarKompanija_KompanijaID",
                table: "KomentarKompanija",
                column: "KompanijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Kompanija_AdresaID",
                table: "Kompanija",
                column: "AdresaID");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_GradID",
                table: "Oglas",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_KategorijaPoslaID",
                table: "Oglas",
                column: "KategorijaPoslaID");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_NivoIskustvaID",
                table: "Oglas",
                column: "NivoIskustvaID");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_PoslodavacID",
                table: "Oglas",
                column: "PoslodavacID");

            migrationBuilder.CreateIndex(
                name: "IX_Oglas_TipPoslaID",
                table: "Oglas",
                column: "TipPoslaID");

            migrationBuilder.CreateIndex(
                name: "IX_OglasSkill_RequiredSkillsID",
                table: "OglasSkill",
                column: "RequiredSkillsID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslodavac_DrzavaID",
                table: "Poslodavac",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Poslodavac_KompanijaID",
                table: "Poslodavac",
                column: "KompanijaID");

            migrationBuilder.CreateIndex(
                name: "IX_PoslodavacZaposlenje_ZaposlenjaID",
                table: "PoslodavacZaposlenje",
                column: "ZaposlenjaID");

            migrationBuilder.CreateIndex(
                name: "IX_ReccLetter_AplikantID",
                table: "ReccLetter",
                column: "AplikantID");

            migrationBuilder.CreateIndex(
                name: "IX_ReccLetter_PoslodavacID",
                table: "ReccLetter",
                column: "PoslodavacID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenje_KompanijaID",
                table: "Zaposlenje",
                column: "KompanijaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Aplikacija");

            migrationBuilder.DropTable(
                name: "AplikantOglas");

            migrationBuilder.DropTable(
                name: "AplikantSkill");

            migrationBuilder.DropTable(
                name: "AplikantZaposlenje");

            migrationBuilder.DropTable(
                name: "Certifikat");

            migrationBuilder.DropTable(
                name: "KomentarKompanija");

            migrationBuilder.DropTable(
                name: "OglasSkill");

            migrationBuilder.DropTable(
                name: "PoslodavacZaposlenje");

            migrationBuilder.DropTable(
                name: "ReccLetter");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Oglas");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Zaposlenje");

            migrationBuilder.DropTable(
                name: "Aplikant");

            migrationBuilder.DropTable(
                name: "KategorijaPosla");

            migrationBuilder.DropTable(
                name: "NivoIskustva");

            migrationBuilder.DropTable(
                name: "Poslodavac");

            migrationBuilder.DropTable(
                name: "TipPosla");

            migrationBuilder.DropTable(
                name: "Kompanija");

            migrationBuilder.DropTable(
                name: "Adresa");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Drzava");

            migrationBuilder.DropSequence(
                name: "KorisnickiRacunSequence");
        }
    }
}
