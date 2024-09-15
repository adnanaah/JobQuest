using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Zaposlenje")]
public class Zaposlenje
{
    public int ID { get; set; }

    [ForeignKey(nameof(Kompanija))]
    public int KompanijaID { get; set; }
    public Kompanija Kompanija { get; set; }

    public string ImeKompanije { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool Current { get; set; }
}