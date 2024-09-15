using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("NivoIskustva")]
public class NivoIskustva
{
    public int ID { get; set; }
    public string Naziv { get; set; }
    public string Opis { get; set; }
}