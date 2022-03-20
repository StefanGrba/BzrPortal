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
    public class AdminVrstaPropisaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminVrstaPropisaController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> ListVrstePropisa()
        {
            return View(await _context.VrstePropisa.ToListAsync());
        }

        [HttpGet]
        public IActionResult CreateVrstaPropisa()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateVrstaPropisa(VrstaPropisaViewModel model)
        {
            if (ModelState.IsValid)
            {
                VrstaPropisa vrstaPropisa = new VrstaPropisa
                {
                    Naziv = model.Naziv
                };
                await _context.VrstePropisa.AddAsync(vrstaPropisa);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Usprešno ste dodali vrstu propisa";
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditVrstaPropisa(int id)
        {
            VrstaPropisa vrsta = await _context.VrstePropisa.FindAsync(id);
            if(vrsta == null)
            {
                return View("Error");
            }

            VrstaPropisaViewModel model = new VrstaPropisaViewModel();
            model.Naziv = vrsta.Naziv;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditVrstaPropisa(VrstaPropisaViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                VrstaPropisa vrsta = await _context.VrstePropisa.FindAsync(id);
                vrsta.Naziv = model.Naziv;
                _context.VrstePropisa.Update(vrsta);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListVrstePropisa");
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteVrstaPropisa(int id)
        {
            VrstaPropisa vrstaPropisa = await _context.VrstePropisa.FindAsync(id);
            if(vrstaPropisa == null)
            {
                return View("Error");
            }
            _context.VrstePropisa.Remove(vrstaPropisa);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListVrstePropisa");
        }
    }
}
