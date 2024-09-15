using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Aplikacija")]
public class Aplikacija
{
    public int ID { get; set; }

    [ForeignKey(nameof(Oglas))]
    public int OglasID { get; set; }
    public Oglas Oglas { get; set; }

    [ForeignKey(nameof(Aplikant))]
    public int AplikantID { get; set; }
    public Aplikant Aplikant { get; set; }

    public byte[] Files { get; set; }
    public string Opis { get; set; }
    public bool Prihvacena { get; set; }
}