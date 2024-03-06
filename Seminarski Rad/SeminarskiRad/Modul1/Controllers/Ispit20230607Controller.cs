﻿using FIT_Api_Examples.Data;
using FIT_Api_Examples.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FIT_Api_Examples.Modul1.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]/[action]")]
    public class Ispit20230607Controller : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public Ispit20230607Controller(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public class TravelFirma
        {
            public int ID { get; set; }
            public string Naziv { get; set; }
        }
       


        private List<string> GetOpcije()
        {
            return Helper.Data.opcije.GetRandomElements(4).OrderBy(a=>a).ToList();
        }

        [HttpGet]
        public object GetTravelFirme()
        {
            return _dbContext.TravelFirma20220924.ToList();
        }


        [HttpGet]
        public object GetPonuda(string travelfirma)
        {
            var a = _dbContext.DestinacijaVM20220924.Where(s=> s.TravelFirma.Naziv == travelfirma)
                .Include(s=>s.TravelFirma).ToList()
                .GetRandomElements(9)
                ;
            a.ForEach(s => s.Opcije = GetOpcije());

            return new
            {
                datumPonude = DateTime.Now.ToString("g"),
                travelfirma = travelfirma?? "Upozorenje. Nema podataka (ponuda) jer nije proslijedjenj query parametar 'travelfirma'! Pogledajte opis na swaggeru. Preuzmite vrijednost 'travelfirme' iz padajuceg menija (HTML SELECT iznad dugmeta BEST OFFERS)... Tri moguće vrijednosti su 'Herc Tours doo', 'Sisic Travel doo', 'Bajro Tours doo'",
                podaci = a
            };
        }

        public class Ispit20230607PosaljiGost
        {
            public string ImeGosta { get; set; }
            public string PrezimeGosta { get; set; }
        }

        public class Ispit20230607Posalji
        {
            public string Destinacija1Soba { get; set; }
            public string Destinacija2Soba { get; set; }
 
            public List<Ispit20230607PosaljiGost> Gosti { get; set; }
            public string Poruka { get; set; }
            public string Email { get; set; }
            public string Telefon { get; set; }
        }


        [HttpPost]
        public ActionResult Add([FromBody] Ispit20230607Posalji x)
        {
            if (string.IsNullOrEmpty(x.Destinacija1Soba))
                return Ok(new
                {
                    poruka = "Podaci su neispravni: Destinacija1Soba",
                    Vrijeme = DateTime.Now,
                    BrojRezervacije = "Podaci su neispravni"
                });

            if (string.IsNullOrEmpty(x.Destinacija2Soba))
                return Ok(new
                {
                    poruka = "Podaci su neispravni: Destinacija2Soba",
                    Vrijeme = DateTime.Now,
                    BrojRezervacije = "000-000"
                });

            if (string.IsNullOrEmpty(x.Email) )
                return Ok(new
                {
                    poruka = "Podaci su neispravni: Email",
                    Vrijeme = DateTime.Now,
                    BrojRezervacije = "000-000"
                });

            if ( string.IsNullOrEmpty(x.Telefon))
                return Ok(new
                {
                    poruka = "Podaci su neispravni: Telefon",
                    Vrijeme = DateTime.Now,
                    BrojRezervacije = "000-000"
                });

            foreach (var g in x.Gosti)
            {
                if (string.IsNullOrEmpty(g.ImeGosta) || string.IsNullOrEmpty(g.PrezimeGosta))
                {
                    return Ok(new
                    {
                        poruka = "Podaci su neispravni: ImeGosta ili PrezimeGosta",
                        Vrijeme = DateTime.Now,
                        BrojRezervacije = "000-000"
                    });
                }
            }

            return Ok( new
            {
                poruka = "Uspjesno evidentirana",
                Vrijeme = DateTime.Now,
                BrojRezervacije = Class.RandomString(5)
            });
        }



       
    }
}
