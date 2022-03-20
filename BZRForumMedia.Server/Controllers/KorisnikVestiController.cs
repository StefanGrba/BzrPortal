namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class KorisnikVestiController : Controller
    {
        private readonly ApplicationDbContext _context;
        public KorisnikVestiController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaVesti()
        {
            List<Vest> vesti = await _context.Vesti
                .Select(v => new Vest { Id = v.Id, Naslov = v.Naslov, PutanjaDoSlike = v.PutanjaDoSlike, Sazetak = v.Sazetak, DatumObjavljivanja = v.DatumObjavljivanja})
                .OrderByDescending(v => v.Id)
                . ToListAsync();
            return View(vesti);
        }

        public async Task<IActionResult> JednaVest(int id)
        {
            Vest vest = await _context.Vesti.FindAsync(id);
            if(vest == null)
            {
                return View("Error");
            }
        
            return View(vest);
        }
    }
}
