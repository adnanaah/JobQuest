using SeminarskiRad_JobQuest.Data;
using SeminarskiRad_JobQuest.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Endpoints.KorisnickiRacunEndpoints.Register;
using SeminarskiRad_JobQuest.Data.Models;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.CodeDom.Compiler;
using SeminarskiRad_JobQuest.Services;

namespace SeminarskiRad_JobQuest.Endpoints.KorisnickiRacunEndpoints.Registracija;

[Route("[controller]")]
public class RegisterEndpoint : MyBaseEndpoint<RegisterRequest, ActionResult<int>>
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly MailService _mailService;
    public RegisterEndpoint(ApplicationDbContext applicationDbContext, MailService mailService)
    {
        _applicationDbContext = applicationDbContext;
        _mailService = mailService;
    }

    [HttpPost]
    public override async Task<ActionResult<int>> Handle([FromBody] RegisterRequest request, CancellationToken cancellationToken)
    {
        var existingUser = await _applicationDbContext.KorisnickiNalog
            .FirstOrDefaultAsync(x => x.IsDeleted == false && x.Username == request.Username, cancellationToken);

        if (existingUser != null)
        {
            return BadRequest("Korisnik sa odabranim korisnickim imenom već postoji. Pokušajte ponovo!");
        }

        KorisnickiRacun newKorisnickiRacun;

        if (request.IsPoslodavac)
        {
            newKorisnickiRacun = new Poslodavac();
        }
        else if (request.IsAplikant)
        {
            newKorisnickiRacun = new Aplikant();
        }
        else
        {
            return BadRequest("Niste odabrali ispravan tip računa");
        }

        var VerificationToken = TokenGenerator.Generate(9);
        await _mailService.SendAsync(request.EmailAddress, "Welcome to JobQuest!", $"Your verification 9-digit code is {VerificationToken}", false);


        newKorisnickiRacun.Username = request.Username;
        newKorisnickiRacun.Password = HashPassword(request.Password);
        newKorisnickiRacun.Ime = request.Ime;
        newKorisnickiRacun.Prezime = request.Prezime;
        newKorisnickiRacun.EmailAddress = request.EmailAddress;
        newKorisnickiRacun.DrzavaID = request.DrzavaID;
        newKorisnickiRacun.VerificationCode = VerificationToken;

        _applicationDbContext.Add(newKorisnickiRacun);
        await _applicationDbContext.SaveChangesAsync(cancellationToken);

        return Ok(newKorisnickiRacun.ID);
    }

    private string HashPassword(string password)
    {
        return PasswordHelper.HashPassword(password);
    }

}