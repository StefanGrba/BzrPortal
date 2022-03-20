namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminClanakController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminClanakController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Clanak> clanci = _context.Clanci.Select(p => new Clanak { Id = p.Id, Naslov = p.Naslov }).ToList();
            return View(clanci);
        }

        [HttpGet]
        public IActionResult CreateClanak()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClanak(ClanakViewModel model)
        {
            if (ModelState.IsValid)
            {
                Clanak clanak = new Clanak
                {
                    Naslov = model.Naslov,
                    Autor = model.Autor,
                    DatumObjavljivanja = model.DatumObjavljivanja,
                    TekstClanka = model.TekstClanka
                };

                await _context.Clanci.AddAsync(clanak);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Članak je uspešno ubačen";
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditClanak(int id)
        {
            Clanak clanak = await _context.Clanci.FindAsync(id);
            if(clanak == null)
            {
                return View("Error");
            }

            ClanakViewModel model = new ClanakViewModel
            {
                Naslov = clanak.Naslov,
                Autor = clanak.Autor,
                DatumObjavljivanja = clanak.DatumObjavljivanja,
                TekstClanka = clanak.TekstClanka
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditClanak(ClanakViewModel model, int id)
        {
            Clanak clanak = await _context.Clanci.FindAsync(id);
            if (clanak == null)
            {
                return View("Error");
            }

            if (ModelState.IsValid)
            {
                clanak.Naslov = model.Naslov;
                clanak.Autor = model.Autor;
                clanak.DatumObjavljivanja = model.DatumObjavljivanja;
                clanak.TekstClanka = model.TekstClanka;
                _context.Clanci.Update(clanak);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AdminClanak");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsClanak(int id)
        {
            Clanak clanak = await _context.Clanci.FindAsync(id);
            if(clanak == null)
            {
                return View("Error");
            }
            ClanakViewModel model = new ClanakViewModel
            {
                Naslov = clanak.Naslov,
                Autor = clanak.Autor,
                DatumObjavljivanja = clanak.DatumObjavljivanja,
                TekstClanka = clanak.TekstClanka
            };
            ViewBag.Id = id;
            return View(model);
        }

        public async Task<IActionResult> DeleteClanak(int id)
        {
            Clanak clanak = await _context.Clanci.FindAsync(id);
            if (clanak == null)
            {
                return View("Error");
            }
            _context.Clanci.Remove(clanak);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AdminClanak");
        }
    }
}
