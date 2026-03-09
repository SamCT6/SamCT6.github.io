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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesBaseball.Data.RazorPagesBaseballContext _context;

        public DetailsModel(RazorPagesBaseball.Data.RazorPagesBaseballContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.Id == id);

            if (game is not null)
            {
                Game = game;

                return Page();
            }

            return NotFound();
        }
    }
}
