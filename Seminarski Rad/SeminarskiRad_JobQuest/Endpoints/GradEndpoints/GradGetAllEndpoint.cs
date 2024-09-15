using SeminarskiRad_JobQuest.Data;
using SeminarskiRad_JobQuest.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Endpoints.GradEnpoints;
using SeminarskiRad_JobQuest.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace SeminarskiRad_JobQuest.Endpoints.GradEnpoints;

[Route("[controller]")]
public class GradGetAllEndpoint : MyBaseEndpoint<NoRequest, GradGetAllResponse>
{
    private readonly ApplicationDbContext _applicationDbContext;
    public GradGetAllEndpoint(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpGet]   
    public override async Task<GradGetAllResponse> Handle([FromQuery]NoRequest request, CancellationToken cancellationToken)
    {

        var response = await _applicationDbContext.Grad
            .Select(x => new GradGetAllResponseGrad(x.ID,x.Naziv + " " + "(" + x.Drzava.Naziv + ")"))
            .ToListAsync(cancellationToken);
        
        return new GradGetAllResponse(response);
    }

}