using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Certifikat")]
public class Certifikat
{
    public int ID { get; set; }
    public string Naziv { get; set; }
    public string Opis { get; set; }
    public byte[] Files { get; set; }
}