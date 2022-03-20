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

    public class KorisnikClanakController : Controller
    {
        private readonly ApplicationDbContext _context;
        public KorisnikClanakController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaClanaka()
        {
            List<Clanak> clanci = await _context.Clanci
                .Select(c => new Clanak { Id = c.Id, Naslov = c.Naslov, Autor = c.Autor })
                .OrderByDescending(c => c.Id)
                .ToListAsync();
            return View(clanci);
        }
        [Authorize(Roles = "Super korisnik, Korisnik")]
        public async Task<IActionResult> JedanClanak(int id)
        {
            Clanak clanak = await _context.Clanci.FindAsync(id);
            return View(clanak);
        }
    }
}
