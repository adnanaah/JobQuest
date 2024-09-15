using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Adresa")]
public class Adresa
{
    public int ID { get; set; }

    [ForeignKey(nameof(Grad))]
    public int GradID { get; set; }
    public Grad Grad { get; set; }
    
    public string? Ulica { get; set; }
    public string? BrojUlice { get; set; }
}