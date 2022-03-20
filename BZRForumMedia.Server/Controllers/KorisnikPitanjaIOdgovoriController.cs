namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class KorisnikPitanjaIOdgovoriController : Controller
    {
        private readonly ApplicationDbContext _context;
        public KorisnikPitanjaIOdgovoriController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaPitanja()
        {
            List<PitanjaIOdgovori> listaPitanja = await _context.PitanjaIOdgovori.OrderByDescending(p => p.Id).ToListAsync();
            return View(listaPitanja);
        }
    }
}
