namespace BZRForumMedia.Server.Controllers
{
    using BZRForumMedia.Server.Data;
    using BZRForumMedia.Server.Models;
    using BZRForumMedia.Server.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    public class VideoArhivaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public VideoArhivaController(ApplicationDbContext context)
        {
            _context = context;
        }
       
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            return View(_context.Video.ToList());
        }
        
        [HttpGet]
        [Authorize(Roles = "Super korisnik")]
        public IActionResult ListaVidea()
        {
            if(!User.IsInRole("Super korisnik"))
            {
                return View("SuperKorisnikError");
            }
            return View(_context.Video.ToList());
        }
        
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create(VideoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Video video = new Video
            {
                Naslov = model.Naslov,
                VideoPath = model.VideoPath
            };

            await _context.Video.AddAsync(video);
            await _context.SaveChangesAsync();
            ViewBag.Msg = "Video je uspešno dodat";
            return View();

        }

        public async Task<IActionResult> Delete(int id)
        {
            Video video = await _context.Video.FindAsync(id);
            _context.Video.Remove(video);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
    }
}
