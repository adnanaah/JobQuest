using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Aplikant")]
public class Aplikant : KorisnickiRacun
{
    public int ID { get; set; }
    public byte[]? CV { get; set; }
    public List<Skill>? Skills { get; set; }
    public List<Zaposlenje>? Zaposlenja { get; set; }
    public List<Oglas>? SpaseniOglasi { get; set; }
    public List<Certifikat>? Certifikati { get; set; }
}