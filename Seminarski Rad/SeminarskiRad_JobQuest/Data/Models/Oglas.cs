using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Oglas")]
public class Oglas
{
    public int ID { get; set; }

    [ForeignKey(nameof(Poslodavac))]
    public int PoslodavacID { get; set; }
    public Poslodavac Poslodavac { get; set; }

    [ForeignKey(nameof(KategorijaPosla))]
    public int KategorijaPoslaID { get; set; }
    public KategorijaPosla KategorijaPosla { get; set; }

    [ForeignKey(nameof(TipPosla))]
    public int TipPoslaID { get; set; }
    public TipPosla TipPosla { get; set; }

    [ForeignKey(nameof(NivoIskustva))]
    public int NivoIskustvaID { get; set; }
    public NivoIskustva NivoIskustva { get; set; }

    [ForeignKey(nameof(Grad))]
    public int GradID { get; set; }
    public Grad Grad { get; set; }

    public List<Skill> RequiredSkills { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public bool ActiveStatus { get; set; }
    public string Opis { get; set; }
}