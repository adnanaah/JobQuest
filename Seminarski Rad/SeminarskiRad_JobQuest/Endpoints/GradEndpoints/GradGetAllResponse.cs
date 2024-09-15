using System.Text.Json.Serialization;

namespace SeminarskiRad_JobQuest.Endpoints.GradEnpoints
{
    public record GradGetAllResponse(List<GradGetAllResponseGrad> Gradovi);
        
    public record GradGetAllResponseGrad(int ID, string Naziv);
}
