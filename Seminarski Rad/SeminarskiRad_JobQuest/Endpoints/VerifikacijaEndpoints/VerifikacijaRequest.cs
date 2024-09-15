using System.Text.Json.Serialization;

namespace SeminarskiRad_JobQuest.Endpoints.VerifikacijaEndpoints
{
    public record VerifikacijaRequest (int AccountID, string VerificationCode);
        
}
