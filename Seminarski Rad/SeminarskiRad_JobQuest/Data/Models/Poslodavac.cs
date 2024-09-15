using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Poslodavac")]
public class Poslodavac : KorisnickiRacun
{
    public int ID { get; set; }

    [ForeignKey(nameof(Kompanija))]
    public int KompanijaID { get; set; }
    public Kompanija Kompanija { get; set; }

    public List<Zaposlenje> Zaposlenja { get; set; }

}