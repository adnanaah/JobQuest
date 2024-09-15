using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("ReccLetter")]
public class ReccLetter
{
    public int ID { get; set; }

    [ForeignKey(nameof(Poslodavac))]
    public int PoslodavacID { get; set; }
    public Poslodavac Poslodavac { get; set; }

    [ForeignKey(nameof(Aplikant))]
    public int AplikantID { get; set; }
    public Aplikant Aplikant { get; set; }

    public string Naslov { get; set; }
    public string Content { get; set; }

}