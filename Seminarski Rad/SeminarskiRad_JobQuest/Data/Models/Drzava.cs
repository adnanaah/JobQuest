using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Drzava")]
public class Drzava
{
    public int ID { get; set; }
    public string Naziv { get; set; }
}