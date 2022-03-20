namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminPodrubrika : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminPodrubrika(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> ListaPodrubrika()
        {
            return View(await _context.Podrubrike.ToListAsync());
        }

        [HttpGet]
        public IActionResult CreatePodrubrika()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePodrubrika(PodrubrikaViewModel model)
        {
            if (ModelState.IsValid)
            {
                Podrubrika podrubrika = new Podrubrika
                {
                    Naziv = model.Naziv
                };
                await _context.Podrubrike.AddAsync(podrubrika);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Uspešno ste dodali rubriku";
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditPodrubrika(int id)
        {
            Podrubrika podrubrika = await _context.Podrubrike.FindAsync(id);
            if(podrubrika == null)
            {
                return View("Error");
            }
            PodrubrikaViewModel model = new PodrubrikaViewModel
            {
                Naziv = podrubrika.Naziv
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPodrubrika(PodrubrikaViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                Podrubrika podrubrika = await _context.Podrubrike.FindAsync(id);
                podrubrika.Naziv = model.Naziv;
                _context.Podrubrike.Update(podrubrika);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListaPodrubrika", "AdminPodrubrika");
            }
            return View(model);
        }

        public async Task<IActionResult> DeletePodrubrika(int id)
        {
            Podrubrika podrubrika = await _context.Podrubrike.FindAsync(id);
            if(podrubrika == null)
            {
                return View("Error");
            }
            _context.Podrubrike.Remove(podrubrika);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListaPodrubrika", "AdminPodrubrika");
        }
    }
}
