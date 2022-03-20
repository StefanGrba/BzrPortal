namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.Services;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Authorize(Roles = "Administrator")]
    public class AdminDokumentacijaController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdminDokumentacijaController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            List<Dokumentacija> dokumenti = await _context.Dokumentacije
                .Select(p => new Dokumentacija { Id = p.Id, Naslov = p.Naslov, Autor = p.Autor, DatumObjavljivanja = p.DatumObjavljivanja })
                .OrderByDescending(p => p.Id)
                .ToListAsync();
            return View(dokumenti);
        }

        [HttpGet]
        public IActionResult CreateDokument()
        {
            List<TipDokumentacije> tipovi = _context.TipoviDokumentacije.ToList();
            ViewBag.Tipovi = tipovi;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDokument(DokumentViewModel model)
        {
            string pdfPath = "";
            string wordPath = "";
            List<TipDokumentacije> tipovi = _context.TipoviDokumentacije.ToList();
            ViewBag.Tipovi = tipovi;

            if (ModelState.IsValid)
            {
                if (model.PdfPutanja != null)
                {
                    string folder = "pdf/";
                    pdfPath = await UploadFile.Upload(folder, model.PdfPutanja, _webHostEnvironment);
                }

                if (model.WordPutanja != null)
                {
                    string folder = "word/";
                    wordPath = await UploadFile.Upload(folder, model.WordPutanja, _webHostEnvironment);
                }

                Dokumentacija dokument = new Dokumentacija
                {
                    Naslov = model.Naslov,
                    Autor = model.Autor,
                    DatumObjavljivanja = model.DatumObjavljivanja,
                    Tekst = model.Tekst,
                    PdfPutanja = pdfPath,
                    WordPutanja = wordPath,
                    Napomena = model.Napomena,
                    IdTipa = model.IdTipa
                };

                await _context.Dokumentacije.AddAsync(dokument);
                await _context.SaveChangesAsync();
                ViewBag.Msg = "Uspešno ste dodali dokument";
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditDokument(int id)
        {
            Dokumentacija dokument = await _context.Dokumentacije.FindAsync(id);
            if(dokument == null)
            {
                return View("Error");
            }
            ViewBag.Id = id;
            ViewBag.Tipovi = await _context.TipoviDokumentacije.ToListAsync();
            DokumentViewModel model = new DokumentViewModel
            {
                Naslov = dokument.Naslov,
                Autor = dokument.Autor,
                DatumObjavljivanja = dokument.DatumObjavljivanja,
                Tekst = dokument.Tekst,
                Napomena = dokument.Napomena,
                IdTipa = dokument.IdTipa
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditDokument(DokumentViewModel model, int id)
        {
            Dokumentacija dokument = await _context.Dokumentacije.FindAsync(id);
            if (dokument == null)
            {
                return View("Error");
            }
            ViewBag.Tipovi = await _context.TipoviDokumentacije.ToListAsync();
            ViewBag.Id = id;
            dokument.Naslov = model.Naslov;
            dokument.Autor = model.Autor;
            dokument.DatumObjavljivanja = model.DatumObjavljivanja;
            dokument.Tekst = model.Tekst;
            dokument.Napomena = model.Napomena;
            dokument.IdTipa = model.IdTipa;
            _context.Dokumentacije.Update(dokument);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "AdminDokumentacija");
        }

        [HttpGet]
        public async Task<IActionResult> DetailsDokument(int id)
        {
            Dokumentacija dokument = await _context.Dokumentacije.FindAsync(id);
            if(dokument == null)
            {
                return View("Error");
            }
         
            return View(dokument);
        }

        public async Task<IActionResult> DeleteDokument(int id)
        {
            var dokument = await _context.Dokumentacije.FindAsync(id);
            if(dokument == null)
            {
                return NotFound();
            }

            _context.Dokumentacije.Remove(dokument);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
