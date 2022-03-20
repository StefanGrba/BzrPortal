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
    public class AdminPitanjaIOdgovoriController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminPitanjaIOdgovoriController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaPitanja()
        {
            List<PitanjaIOdgovori> pitanja = await _context.PitanjaIOdgovori
                .Select(p => new PitanjaIOdgovori { Id = p.Id, Pitanje = p.Pitanje})
                .OrderByDescending(p => p.Id).ToListAsync();
            return View(pitanja);
        }

        [HttpGet]
        public IActionResult CreatePitanja()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePitanja(PitanjaIOdgovoriViewModel model)
        {
            if (ModelState.IsValid)
            {
                PitanjaIOdgovori pitanje = new PitanjaIOdgovori
                {
                    Naslov = model.Naslov,
                    Pitanje = model.Pitanje,
                    Odgovor = model.Odgovor
                };
                await _context.PitanjaIOdgovori.AddAsync(pitanje);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Uspešno je dodato";
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditPitanja(int id)
        {
            PitanjaIOdgovori pitanje = await _context.PitanjaIOdgovori.FindAsync(id);
            if(pitanje == null)
            {
                return View("Error");
            }
            PitanjaIOdgovoriViewModel model = new PitanjaIOdgovoriViewModel
            {
                Naslov = pitanje.Naslov,
                Pitanje = pitanje.Pitanje,
                Odgovor = pitanje.Odgovor
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPitanja(PitanjaIOdgovoriViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                PitanjaIOdgovori pitanje = await _context.PitanjaIOdgovori.FindAsync(id);
                pitanje.Naslov = model.Naslov;
                pitanje.Pitanje = model.Pitanje;
                pitanje.Odgovor = model.Odgovor;
                _context.PitanjaIOdgovori.Update(pitanje);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListaPitanja");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsPitanja(int id)
        {
            PitanjaIOdgovori pitanje = await _context.PitanjaIOdgovori.FindAsync(id);
            if(pitanje == null)
            {
                return View("Error");
            }
            ViewBag.Id = id;
            PitanjaIOdgovoriViewModel model = new PitanjaIOdgovoriViewModel
            {
                Naslov = pitanje.Naslov,
                Pitanje = pitanje.Pitanje,
                Odgovor = pitanje.Odgovor
            };
            return View(model);
        }

        public async Task<IActionResult> DeletePitanja(int id)
        {
            PitanjaIOdgovori pitanje = await _context.PitanjaIOdgovori.FindAsync(id);
            if(pitanje == null)
            {
                return View("Error");
            }
            _context.PitanjaIOdgovori.Remove(pitanje);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaPitanja");
        }

    }
}
