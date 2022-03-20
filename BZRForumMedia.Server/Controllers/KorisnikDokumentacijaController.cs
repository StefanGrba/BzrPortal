namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class KorisnikDokumentacijaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public KorisnikDokumentacijaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaDokumenata(int id)
        {
            List<Dokumentacija> dokumenti = await _context.Dokumentacije
                .Where(d => d.IdTipa == id)
                .Select(d => new Dokumentacija { Id = d.Id, Naslov = d.Naslov, DatumObjavljivanja = d.DatumObjavljivanja })
                .OrderByDescending(d => d.Id)
                .ToListAsync();
            return View(dokumenti);
        }

        [Authorize(Roles = "Super korisnik, Korisnik")]
        public async Task<IActionResult> JedanDokument(int id)
        {
            Dokumentacija dokument = await _context.Dokumentacije.FindAsync(id);
            return View(dokument);
        }
    }
}
