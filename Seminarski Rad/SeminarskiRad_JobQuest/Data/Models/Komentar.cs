using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Komentar")]
public class Komentar
{
    public int ID { get; set; }
    public string Content { get; set; }
    public DateTime DatumUnosa { get; set; }
}