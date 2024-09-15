using SeminarskiRad_JobQuest.Data;
using SeminarskiRad_JobQuest.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Endpoints.GradEnpoints;
using SeminarskiRad_JobQuest.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace SeminarskiRad_JobQuest.Endpoints.DrzavaEndpoints;

[Route("[controller]")]
public class DrzavaGetAllEndpoint : MyBaseEndpoint<NoRequest, DrzavaGetAllResponse>
{
    private readonly ApplicationDbContext _applicationDbContext;
    public DrzavaGetAllEndpoint(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpGet]   
    public override async Task<DrzavaGetAllResponse> Handle([FromQuery]NoRequest request, CancellationToken cancellationToken)
    {

        var response = await _applicationDbContext.Drzava
            .Select(x => new DrzavaGetAllResponseDrzava(x.ID,x.Naziv))
            .ToListAsync(cancellationToken);
        
        return new DrzavaGetAllResponse(response);
    }

}