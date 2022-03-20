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
    public class AdminRubrikaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminRubrikaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> SpisakRubrika()
        {
            return View(await _context.Rubrike.ToListAsync());
        }
        [HttpGet]
        public IActionResult CreateRubrika()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRubrika(RubrikaViewModel model) 
        {
            if (ModelState.IsValid)
            {
                Rubrika rubrika = new Rubrika
                {
                    Naziv = model.Naziv
                };
                await _context.Rubrike.AddAsync(rubrika);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Rubrika je uspešno dodata";
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditRubrika(int id)
        {
            Rubrika rubrika = _context.Rubrike.Find(id);
            if(rubrika == null)
            {
                return View("Not Found");
            }
            RubrikaViewModel model = new RubrikaViewModel();
            model.Naziv = rubrika.Naziv;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRubrika(RubrikaViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                Rubrika rubrika = await _context.Rubrike.FindAsync(id);
                rubrika.Naziv = model.Naziv;
                _context.Rubrike.Update(rubrika);
                await _context.SaveChangesAsync();
                return RedirectToAction("SpisakRubrika", "AdminRubrika");

            }
            return View(model);
        }
        
        public async Task<IActionResult> DeleteRubrika(int id)
        {
            Rubrika rubrika = await _context.Rubrike.FindAsync(id);
            if(rubrika == null)
            {
                return View("Error");
            }
            _context.Rubrike.Remove(rubrika);
            await _context.SaveChangesAsync();
            return RedirectToAction("SpisakRubrika", "AdminRubrika");
        }
    }
}
