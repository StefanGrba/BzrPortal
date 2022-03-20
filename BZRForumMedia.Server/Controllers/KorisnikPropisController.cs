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

    public class KorisnikPropisController : Controller
    {
        private readonly ApplicationDbContext _context;
        public KorisnikPropisController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaPropisa(int id)
        {
            List<Propis> propisi = await _context.Propisi
                .Where(p => p.IdVrstaPropis == id)
                .Select(p => new Propis { Id = p.Id, Naslov = p.Naslov, GlasiloIDatum = p.GlasiloIDatum, IdVrstaPropis = p.IdVrstaPropis, DatumStupanjaNaSnaguPropisa = p.DatumStupanjaNaSnaguPropisa })
                .ToListAsync();
            return View(propisi);
        }

        [Authorize(Roles = "Korisnik, Super korisnik")]
        public async Task<IActionResult> JedanPropis(int id)
        {
            var propis = await _context.Propisi.FindAsync(id);
            return View(propis);
        }
    }
}
