using System.Text.Json.Serialization;

namespace SeminarskiRad_JobQuest.Endpoints.DrzavaEndpoints
{
    public record DrzavaGetAllResponse(List<DrzavaGetAllResponseDrzava> Drzave);
        
    public record DrzavaGetAllResponseDrzava(int ID, string Naziv);
}
