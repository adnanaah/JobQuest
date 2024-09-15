using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarskiRad_JobQuest.Data.Models;

[Table("Administrator")]
public class Administrator : KorisnickiRacun
{
    public int ID { get; set; }
    public bool UserVerification { get; set; }
}