using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("KategorijaPosla")]
public class KategorijaPosla
{
    public int ID { get; set; }
    public string Naziv { get; set; }
    public string Opis { get; set; }
}