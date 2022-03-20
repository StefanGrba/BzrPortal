namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.Services;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminVestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminVestController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Vest> vesti = _context.Vesti.OrderByDescending(v => v.Id).ToList();
            return View(vesti);
        }

        [HttpGet]
        public IActionResult CreateVest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVest(VestViewModel model)
        {
            if (ModelState.IsValid)
            {
                string imgPath = "";
                if (model.PutanjaDoSlike != null)
                {
                    string folder = "imgVesti/";
                    imgPath = await UploadFile.Upload(folder, model.PutanjaDoSlike, _webHostEnvironment);
                }
                Vest vest = new Vest
                {
                    Naslov = model.Naslov,
                    Podnaslov = model.Podnaslov,
                    DatumObjavljivanja = model.DatumObjavljivanja,
                    Tekst = model.Tekst,
                    Sazetak = model.Sazetak,
                    PutanjaDoSlike = imgPath
                };

                await _context.Vesti.AddAsync(vest);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Vest je uspešno dodata";
            }
            return View(model);

        }

        [HttpGet]
        public async Task<IActionResult> EditVest(int id)
        {
            Vest vest = await _context.Vesti.FindAsync(id);
            if(vest == null)
            {
                return View("Error");
            }
            VestViewModel model = new VestViewModel
            {
                Naslov = vest.Naslov,
                Podnaslov = vest.Podnaslov,
                Tekst = vest.Tekst,
                Sazetak = vest.Sazetak,
                DatumObjavljivanja = vest.DatumObjavljivanja
            };
            ViewBag.Id = id;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditVest(VestViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                Vest vest = await _context.Vesti.FindAsync(id);
                if(vest == null)
                {
                    return View("Error");
                }
                vest.Naslov = model.Naslov;
                vest.Podnaslov = model.Podnaslov;
                vest.DatumObjavljivanja = model.DatumObjavljivanja;
                vest.Tekst = model.Tekst;
                vest.Sazetak = model.Sazetak;
                _context.Vesti.Update(vest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "AdminVest");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DetailsVest(int id)
        {
            Vest vest = await _context.Vesti.FindAsync(id);
            if(vest == null)
            {
                return View("Error");
            }

            VestViewModel model = new VestViewModel
            {
                Naslov = vest.Naslov,
                Podnaslov = vest.Podnaslov,
                DatumObjavljivanja = vest.DatumObjavljivanja,
                Tekst = vest.Tekst,
                Sazetak = vest.Sazetak,
            };
            return View(model);
        }

        public async Task<IActionResult> DeleteVest(int id)
        {
            Vest vest = await _context.Vesti.FindAsync(id);
            if(vest == null)
            {
                return View("Error");
            }
            _context.Vesti.Remove(vest);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AdminVest");
        }
    }
}
