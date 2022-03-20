using BZRForumMedia.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BZRForumMedia.Server.Components
{
    public class TipoviDokumentacijeViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public TipoviDokumentacijeViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tipovi = await _context.TipoviDokumentacije.ToListAsync();
            return View(tipovi);
        }
    }
}
