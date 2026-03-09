using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBaseball.Data;
using RazorPagesBaseball.Models;

namespace RazorPagesBaseball.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBaseball.Data.RazorPagesBaseballContext _context;

        public IndexModel(RazorPagesBaseball.Data.RazorPagesBaseballContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
