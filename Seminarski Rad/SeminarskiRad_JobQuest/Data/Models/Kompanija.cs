using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Kompanija")]
public class Kompanija
{
    public int ID { get; set; }
    public string Naziv { get; set; }
    public DateTime DatumOsnivanja { get; set; }
    public string Opis { get; set; }
    public int EmployeeCount { get; set; }
    public List<Komentar> Komentari { get; set; }

    [ForeignKey(nameof(Adresa))]
    public int AdresaID { get; set; }
    public Adresa Adresa { get; set; }
}