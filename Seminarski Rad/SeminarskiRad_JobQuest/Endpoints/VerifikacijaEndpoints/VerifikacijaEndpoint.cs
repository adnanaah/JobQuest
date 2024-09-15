using SeminarskiRad_JobQuest.Data;
using SeminarskiRad_JobQuest.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Endpoints.GradEnpoints;
using SeminarskiRad_JobQuest.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace SeminarskiRad_JobQuest.Endpoints.VerifikacijaEndpoints;

[Route("[controller]")]
public class VerifikacijaEndpoint : MyBaseEndpoint<VerifikacijaRequest, ActionResult>
{
    private readonly ApplicationDbContext _applicationDbContext;
    public VerifikacijaEndpoint(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }

    [HttpPost]
    public override async Task<ActionResult> Handle([FromBody] VerifikacijaRequest request, CancellationToken cancellationToken)
    {
        var user = await _applicationDbContext.KorisnickiNalog.FindAsync(request.AccountID);
        if (user == null)
        {
            return BadRequest("Korisnicki racun ne postoji!");
        }

        if(request.VerificationCode == user.VerificationCode)
        {
            user.VerifiedAccount = true;
            await _applicationDbContext.SaveChangesAsync(cancellationToken);
            return Ok();
        }

        return BadRequest("Neispravan verifikacijski kod pokusajte ponovo");

    }


}