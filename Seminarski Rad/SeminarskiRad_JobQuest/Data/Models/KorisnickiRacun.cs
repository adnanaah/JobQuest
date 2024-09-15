using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SeminarskiRad_JobQuest.Data.Models;

public abstract class KorisnickiRacun
{
    [Key]
    public int ID { get; set; }
    public string Username { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
    public string? UserProfilePicture { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string EmailAddress { get; set; }
    public string? VerificationCode { get; set; }
    public bool VerifiedAccount { get; set; } = false;
    public bool IsDeleted { get; set; } = false;
    public DateTime? DatumRodjenja { get; set; }

    [ForeignKey(nameof(Drzava))]
    public int DrzavaID { get; set; }
    public Drzava Drzava { get; set; }

}