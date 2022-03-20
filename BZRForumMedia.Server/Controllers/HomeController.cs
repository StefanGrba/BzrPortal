namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Vest> vesti = await _context.Vesti
                .Select(v => new Vest {Id = v.Id, Naslov = v.Naslov, Podnaslov = v.Podnaslov, DatumObjavljivanja = v.DatumObjavljivanja, Sazetak = v.Sazetak, PutanjaDoSlike = v.PutanjaDoSlike })
                .OrderByDescending(v => v.Id)
                .ToListAsync();
            return View(vesti);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string id)
        {
            var propisi = await _context.Propisi
                .Where(p => p.Naslov.Contains(id))
                .Select(p => new Propis { Id = p.Id, Naslov = p.Naslov, GlasiloIDatum = p.GlasiloIDatum, DatumStupanjaNaSnaguPropisa = p.DatumStupanjaNaSnaguPropisa }).ToListAsync();

            var dokumenti = await _context.Dokumentacije
                .Where(d => d.Naslov.Contains(id))
                .Select(d => new Dokumentacija { Id = d.Id, Naslov = d.Naslov}).ToListAsync();

            var strucniTekstovi = await _context.Clanci
                .Where(c => c.Naslov.Contains(id))
                .Select(c => new Clanak { Id = c.Id, Naslov = c.Naslov, Autor = c.Autor }).ToListAsync();

            ViewBag.Dokumenti = dokumenti;
            ViewBag.Clanci = strucniTekstovi;

            return View(propisi);
        }

        public IActionResult Kontakt()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
