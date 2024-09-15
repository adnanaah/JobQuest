using SeminarskiRad_JobQuest.Data;
using SeminarskiRad_JobQuest.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.CodeDom.Compiler;
using SeminarskiRad_JobQuest.Services;

namespace SeminarskiRad_JobQuest.Endpoints.KorisnickiRacunEndpoints.Delete;

[Route("[controller]")]
public class DeleteEndpoint : MyBaseEndpoint<int, ActionResult<int>>
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly MailService _mailService;
    public DeleteEndpoint(ApplicationDbContext applicationDbContext, MailService mailService)
    {
        _applicationDbContext = applicationDbContext;
        _mailService = mailService;
    }

    [HttpPost]
    public override async Task<ActionResult<int>> Handle([FromBody] int UserID, CancellationToken cancellationToken)
    {
        var user = await _applicationDbContext.KorisnickiNalog.FindAsync(UserID);

        if (user == null) {
            return BadRequest("Korisnik sa odabranim ID ne postoji!");
        }

        user.IsDeleted = true;
        await _applicationDbContext.SaveChangesAsync(cancellationToken);
        return Ok();
    }

}