namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminTipDokumentacijeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminTipDokumentacijeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tipovi = _context.TipoviDokumentacije.ToList().OrderByDescending(t => t.Id);
            return View(tipovi);
        }
        [HttpGet]
        public IActionResult CreateTip()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTip(TipDokumentacijeViewModel model)
        {
            if (ModelState.IsValid)
            {
                TipDokumentacije tip = new TipDokumentacije
                {
                    ImeTipa = model.ImeTipa
                };
                await _context.TipoviDokumentacije.AddAsync(tip);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Tip je uspešno kreiran";
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditTip(int id)
        {
            TipDokumentacije tip = await _context.TipoviDokumentacije.FindAsync(id);
            if(tip == null)
            {
                return View("Error");
            }

            TipDokumentacijeViewModel model = new TipDokumentacijeViewModel
            {
                ImeTipa = tip.ImeTipa
            };
            ViewBag.Id = id;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditTip(TipDokumentacijeViewModel model, int id)
        {
            TipDokumentacije tip = await _context.TipoviDokumentacije.FindAsync(id);
            ViewBag.Id = id;
            if (tip == null)
            {
                return View("Error");
            }
            if (ModelState.IsValid)
            {
                tip.ImeTipa = model.ImeTipa;
                _context.TipoviDokumentacije.Update(tip);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AdminTipDokumentacije");
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteTip(int id)
        {
            TipDokumentacije tip = await _context.TipoviDokumentacije.FindAsync(id);
            if(tip == null)
            {
                return View("Error");
            }

            _context.TipoviDokumentacije.Remove(tip);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AdminTipDokumentacije");

        }
    }
}
