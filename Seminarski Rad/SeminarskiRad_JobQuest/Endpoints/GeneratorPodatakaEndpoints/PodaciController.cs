using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using SeminarskiRad_JobQuest.Data.dbContext;
using SeminarskiRad_JobQuest.Data.Models;

namespace SeminarskiRad_JobQuest.Endpoints.PodaciEndpoints;

//[Authorize]
[ApiController]
[Route("[controller]/[action]")]
public class PodaciController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public PodaciController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public ActionResult Count()
    {
        Dictionary<string, int> data = new Dictionary<string, int>();
        data.Add("drzava", _dbContext.Drzava.Count());
        data.Add("grad", _dbContext.Grad.Count());
        return Ok(data);
    }

    [HttpPost]
    public ActionResult Generisi()
    {
        var drzave = new List<Drzava>();
        var gradovi = new List<Grad>();

        drzave.Add(new Drzava { Naziv = "BiH" });
        drzave.Add(new Drzava { Naziv = "HR" });
        drzave.Add(new Drzava { Naziv = "Njemacka" });
        drzave.Add(new Drzava { Naziv = "Austrija" });
        drzave.Add(new Drzava { Naziv = "SAD" });
        drzave.Add(new Drzava { Naziv = "Malezija" });

        gradovi.Add(new Grad { Naziv = "Sarajevo", Drzava = drzave[0] });
        gradovi.Add(new Grad { Naziv = "Mostar", Drzava = drzave[0] });
        gradovi.Add(new Grad { Naziv = "Zenica", Drzava = drzave[0] });
                               
        gradovi.Add(new Grad { Naziv = "Split", Drzava = drzave[1] });
        gradovi.Add(new Grad { Naziv = "Zagreb", Drzava = drzave[1] });
                               
        gradovi.Add(new Grad { Naziv = "Berlin", Drzava = drzave[2] });
        gradovi.Add(new Grad { Naziv = "Wiebaden", Drzava = drzave[2] });
                               
        gradovi.Add(new Grad { Naziv = "Gratz", Drzava = drzave[3] });
        gradovi.Add(new Grad { Naziv = "Klagenfurt", Drzava = drzave[3] });
                                
        gradovi.Add(new Grad { Naziv = "Boston", Drzava = drzave[4] });
        gradovi.Add(new Grad { Naziv = "New York", Drzava = drzave[4] });
                               
        gradovi.Add(new Grad { Naziv = "Kuala Lumpur", Drzava = drzave[5] });
        gradovi.Add(new Grad { Naziv = "Subang Jaya", Drzava = drzave[5] });

        _dbContext.AddRange(drzave);
        _dbContext.AddRange(gradovi);
        _dbContext.SaveChanges();

        return Count();
    }





}