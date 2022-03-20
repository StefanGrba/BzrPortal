namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminPropisController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminPropisController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListaPropisa()
        {
            List<Propis> propisi = await _context.Propisi
                .Select(p => new Propis{Id = p.Id, Naslov = p.Naslov, GlasiloIDatum = p.GlasiloIDatum })
                .OrderByDescending(p => p.Id).ToListAsync();
            return View(propisi);
        }

        [HttpGet]
        public IActionResult CreatePropis()
        {
            List<VrstaPropisa> vrstePropisa = _context.VrstePropisa.ToList();
            ViewBag.Vrste = vrstePropisa;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropis(PropisViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                Propis propis = new Propis
                {
                    Naslov = model.Naslov,
                    GlasiloIDatum = model.GlasiloIDatum,
                    IdVrstaPropis = model.IdVrstaPropis,
                    Donosilac = model.Donosilac,
                    NivoVazenja = model.NivoVazenja,
                    DatumStupanjaNaSnaguPropisa = model.DatumStupanjaNaSnaguPropisa,
                    DatumPrestankaVerzije = model.DatumPrestankaVerzije,
                    DatumObjavljivanjeVerzije = model.DatumObjavljivanjeVerzije,
                    DatumObjavljivanjaOsnovnogTeksta = model.DatumObjavljivanjaOsnovnogTeksta,
                    DatumStupanjaNaSnaguMedjunarodnogUgovora = model.DatumStupanjaNaSnaguMedjunarodnogUgovora,
                    DatumStupanjaNaSnaguOsnovnogTeksta = model.DatumStupanjaNaSnaguOsnovnogTeksta,
                    DatumPrestankaVazenjaPropisa = model.DatumPrestankaVazenjaPropisa,
                    DatumPocetkaPrimene = model.DatumPocetkaPrimene,
                    PravniOsnovZaDonosenjePropisa = model.PravniOsnovZaDonosenjePropisa,
                    NormaOsnovaZaDonosenje = model.NormaOsnovaZaDonosenje,
                    PropisKojiJePrestaoDaVazi = model.PropisKojiJePrestaoDaVazi,
                    NormaOsnovaZaPrestanakVazenja = model.NormaOsnovaZaPrestanakVazenja,
                    DatumPrestankaVazenjaPravnogPrethodnika = model.DatumPrestankaVazenjaPravnogPrethodnika,
                    IstorijskaVerzijaPropisa = model.IstorijskaVerzijaPropisa,
                    Napomena = model.Napomena,
                    NapomenaGlasnika = model.NapomenaGlasnika
                };
                await _context.Propisi.AddAsync(propis);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Uspešno ste dodali propis";
                return View();
            }

            List<VrstaPropisa> vrstePropisa = _context.VrstePropisa.ToList();
            ViewBag.Vrste = vrstePropisa;
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> EditPropis(int id)
        {
            Propis propis = await _context.Propisi.FindAsync(id);
            if(propis == null)
            {
                return View("Error");
            }
            ViewBag.VrstePropisa = await _context.VrstePropisa.ToListAsync();
            PropisViewModel model = new PropisViewModel
            {
                Naslov = propis.Naslov,
                GlasiloIDatum = propis.GlasiloIDatum,
                IdVrstaPropis = propis.IdVrstaPropis,
                Donosilac = propis.Donosilac,
                NivoVazenja = propis.NivoVazenja,
                DatumStupanjaNaSnaguPropisa = propis.DatumStupanjaNaSnaguPropisa,
                DatumPrestankaVerzije = propis.DatumPrestankaVerzije,
                DatumObjavljivanjeVerzije = propis.DatumObjavljivanjeVerzije,
                DatumObjavljivanjaOsnovnogTeksta = propis.DatumObjavljivanjaOsnovnogTeksta,
                DatumStupanjaNaSnaguMedjunarodnogUgovora = propis.DatumStupanjaNaSnaguMedjunarodnogUgovora,
                DatumStupanjaNaSnaguOsnovnogTeksta = propis.DatumStupanjaNaSnaguOsnovnogTeksta,
                DatumPrestankaVazenjaPropisa = propis.DatumPrestankaVazenjaPropisa,
                DatumPocetkaPrimene = propis.DatumPocetkaPrimene,
                PravniOsnovZaDonosenjePropisa = propis.PravniOsnovZaDonosenjePropisa,
                NormaOsnovaZaDonosenje = propis.NormaOsnovaZaDonosenje,
                PropisKojiJePrestaoDaVazi = propis.PropisKojiJePrestaoDaVazi,
                NormaOsnovaZaPrestanakVazenja = propis.NormaOsnovaZaPrestanakVazenja,
                DatumPrestankaVazenjaPravnogPrethodnika = propis.DatumPrestankaVazenjaPravnogPrethodnika,
                IstorijskaVerzijaPropisa = propis.IstorijskaVerzijaPropisa,
                Napomena = propis.Napomena,
                NapomenaGlasnika = propis.NapomenaGlasnika,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPropis(PropisViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                ViewBag.VrstePropisa = await _context.VrstePropisa.ToListAsync();
                Propis propis = await _context.Propisi.FindAsync(id);
                propis.Naslov = model.Naslov;
                propis.GlasiloIDatum = model.GlasiloIDatum;
                propis.IdVrstaPropis = model.IdVrstaPropis;
                propis.Donosilac = model.Donosilac;
                propis.NivoVazenja = model.NivoVazenja;
                propis.DatumStupanjaNaSnaguPropisa = model.DatumStupanjaNaSnaguPropisa;
                propis.DatumPrestankaVerzije = model.DatumPrestankaVerzije;
                propis.DatumObjavljivanjeVerzije = model.DatumObjavljivanjeVerzije;
                propis.DatumObjavljivanjaOsnovnogTeksta = model.DatumObjavljivanjaOsnovnogTeksta;
                propis.DatumStupanjaNaSnaguMedjunarodnogUgovora = model.DatumStupanjaNaSnaguMedjunarodnogUgovora;
                propis.DatumStupanjaNaSnaguOsnovnogTeksta = model.DatumStupanjaNaSnaguOsnovnogTeksta;
                propis.DatumPrestankaVazenjaPropisa = model.DatumPrestankaVazenjaPropisa;
                propis.DatumPocetkaPrimene = model.DatumPocetkaPrimene;
                propis.PravniOsnovZaDonosenjePropisa = model.PravniOsnovZaDonosenjePropisa;
                propis.NormaOsnovaZaDonosenje = model.NormaOsnovaZaDonosenje;
                propis.PropisKojiJePrestaoDaVazi = model.PropisKojiJePrestaoDaVazi;
                propis.NormaOsnovaZaPrestanakVazenja = model.NormaOsnovaZaPrestanakVazenja;
                propis.DatumPrestankaVazenjaPravnogPrethodnika = model.DatumPrestankaVazenjaPravnogPrethodnika;
                propis.IstorijskaVerzijaPropisa = model.IstorijskaVerzijaPropisa;
                propis.Napomena = model.Napomena;
                propis.NapomenaGlasnika = model.NapomenaGlasnika;
                _context.Propisi.Update(propis);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Izmene su uspešno izvršene";
                return View(model);

            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsPropis(int id)
        {
            Propis propis = await _context.Propisi.FindAsync(id);
            ViewBag.Id = id;
            PropisViewModel model = new PropisViewModel
            {
                Naslov = propis.Naslov,
                GlasiloIDatum = propis.GlasiloIDatum,
                IdVrstaPropis = propis.IdVrstaPropis,
                Donosilac = propis.Donosilac,
                NivoVazenja = propis.NivoVazenja,
                DatumStupanjaNaSnaguPropisa = propis.DatumStupanjaNaSnaguPropisa,
                DatumPrestankaVerzije = propis.DatumPrestankaVerzije,
                DatumObjavljivanjeVerzije = propis.DatumObjavljivanjeVerzije,
                DatumObjavljivanjaOsnovnogTeksta = propis.DatumObjavljivanjaOsnovnogTeksta,
                DatumStupanjaNaSnaguMedjunarodnogUgovora = propis.DatumStupanjaNaSnaguMedjunarodnogUgovora,
                DatumStupanjaNaSnaguOsnovnogTeksta = propis.DatumStupanjaNaSnaguOsnovnogTeksta,
                DatumPrestankaVazenjaPropisa = propis.DatumPrestankaVazenjaPropisa,
                DatumPocetkaPrimene = propis.DatumPocetkaPrimene,
                PravniOsnovZaDonosenjePropisa = propis.PravniOsnovZaDonosenjePropisa,
                NormaOsnovaZaDonosenje = propis.NormaOsnovaZaDonosenje,
                PropisKojiJePrestaoDaVazi = propis.PropisKojiJePrestaoDaVazi,
                NormaOsnovaZaPrestanakVazenja = propis.NormaOsnovaZaPrestanakVazenja,
                DatumPrestankaVazenjaPravnogPrethodnika = propis.DatumPrestankaVazenjaPravnogPrethodnika,
                IstorijskaVerzijaPropisa = propis.IstorijskaVerzijaPropisa,
                Napomena = propis.Napomena,
                NapomenaGlasnika = propis.NapomenaGlasnika

            };
            return View(model);

        }

        public async Task<IActionResult> DodajTekst(int id)
        {
            Propis propis = await _context.Propisi.FindAsync(id);
            if(propis == null)
            {
                return View("Error");
            }
            PropisViewModel model = new PropisViewModel
            {
                TekstPropisa = propis.TekstPropisa
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DodajTekst(PropisViewModel model, int id)
        {
            Propis propis = await _context.Propisi.FindAsync(id);
            if(propis == null)
            {
                return View("Error");
            }
            propis.TekstPropisa = model.TekstPropisa;
            _context.Propisi.Update(propis);
            await _context.SaveChangesAsync();
            ViewBag.Msg = "Tekst je uspešno dodat";
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> IscitajTekst(int id)
        {
            Propis propis = _context.Propisi.Find(id);
            if(propis == null)
            {
                return View("Error");
            }
            ViewBag.Id = id;
            PropisViewModel model = new PropisViewModel
            {
                Naslov = propis.Naslov,
                GlasiloIDatum = propis.GlasiloIDatum,
                TekstPropisa = propis.TekstPropisa
            };
            return View(model);
        }

        public async Task<IActionResult> DeletePropis(int id)
        {
            Propis propis = await _context.Propisi.FindAsync(id);
            if(propis == null)
            {
                return View("Error");
            }
            _context.Propisi.Remove(propis);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaPropisa", "AdminPropis");
        }

    }
}
