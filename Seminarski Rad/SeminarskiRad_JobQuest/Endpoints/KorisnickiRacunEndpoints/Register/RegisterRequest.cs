using System.Text.Json.Serialization;

namespace SeminarskiRad_JobQuest.Endpoints.KorisnickiRacunEndpoints.Register
{
    public class RegisterRequest
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EmailAddress { get; set; }
        public int DrzavaID { get; set; }
        public bool IsAplikant { get; set; } = false;
        public bool IsPoslodavac { get; set; } = false;
    }
}
