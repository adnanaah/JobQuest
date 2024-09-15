using Microsoft.EntityFrameworkCore;
using SeminarskiRad_JobQuest.Data.Models;

namespace SeminarskiRad_JobQuest.Data.dbContext;

public class ApplicationDbContext : DbContext
{
    
    public DbSet<KorisnickiRacun> KorisnickiNalog { get; set; } 
    public DbSet<Aplikant> Aplikant { get; set; }
    public DbSet<Poslodavac> Poslodavac { get; set; }
    public DbSet<Administrator> Administrator { get; set; }
    public DbSet<Oglas> Oglas { get; set; }
    public DbSet<Aplikacija> Aplikacija { get; set; }
    public DbSet<Kompanija> Kompanija { get; set; }
    public DbSet<Zaposlenje> Zaposlenje { get; set; }
    public DbSet<Certifikat> Certifikat { get; set; }
    public DbSet<Adresa> Adresa { get; set; }
    public DbSet<ReccLetter> ReccLetter { get; set; }    
    public DbSet<Drzava> Drzava { get; set; }
    public DbSet<Grad> Grad { get; set; }
    public DbSet<TipPosla> TipPosla { get; set; }
    public DbSet<NivoIskustva> NivoIskustva { get; set; }
    public DbSet<KategorijaPosla> KategorijaPosla { get; set; }
    public DbSet<Skill> Skill { get; set; }
    public DbSet<Komentar> Komentar { get; set; }


    public ApplicationDbContext(
        DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.NoAction;
        }

        modelBuilder.Entity<Aplikant>()
        .HasMany(a => a.Skills)
        .WithMany();

        modelBuilder.Entity<Aplikant>()
        .HasMany(a => a.Zaposlenja)
        .WithMany();

        modelBuilder.Entity<Aplikant>()
        .HasMany(a => a.SpaseniOglasi)
        .WithMany();

        modelBuilder.Entity<Poslodavac>()
        .HasMany(a => a.Zaposlenja)
        .WithMany();

        modelBuilder.Entity<Oglas>()
        .HasMany(a => a.RequiredSkills)
        .WithMany();

        modelBuilder.Entity<Kompanija>()
        .HasMany(a => a.Komentari)
        .WithMany();

        modelBuilder.Entity<KorisnickiRacun>().UseTpcMappingStrategy();
    }
}