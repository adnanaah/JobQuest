using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Grad")]
public class Grad
{
    public int ID { get; set; }
    public string Naziv { get; set; }

    [ForeignKey(nameof(Drzava))]
    public int DrzavaID { get; set; }
    public Drzava Drzava { get; set; }
}