using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBaseball.Data;
using RazorPagesBaseball.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Opponent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GameOpponent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GameResult { get; set; }

        public SelectList? Results { get; set; }


            public async Task OnGetAsync() 
            {
                IQueryable<string> resultQuery = from m in _context.Game
                                                orderby m.Result
                                                select m.Result;

                var games = from m in _context.Game
                            select m;

                if (!string.IsNullOrEmpty(SearchString))
                {
                    games = games.Where(s => s.Opponent.Contains(SearchString));
                }

                if (!string.IsNullOrEmpty(GameResult))
                {
                    games = games.Where(x => x.Result == GameResult);
                }

                Results = new SelectList(await resultQuery.Distinct().ToListAsync());
                Game = await games.ToListAsync();
            }
        }
    }