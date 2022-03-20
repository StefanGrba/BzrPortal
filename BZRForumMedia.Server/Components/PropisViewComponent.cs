using BZRForumMedia.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BZRForumMedia.Server.Views.Components
{
    public class PropisViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public PropisViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vrste = await _context.VrstePropisa.ToListAsync();
            return View(vrste);
        }
    }
}
