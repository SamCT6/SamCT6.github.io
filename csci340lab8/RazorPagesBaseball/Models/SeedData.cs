using Microsoft.EntityFrameworkCore;
using RazorPagesBaseball.Data;

namespace RazorPagesBaseball.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesBaseballContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesBaseballContext>>()))
        {
            if (context == null || context.Game == null)
            {
                throw new ArgumentNullException("Null RazorPagesBaseballContext");
            }


            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }

            context.Game.AddRange(
                new Game
                {
                    Opponent = "Centenary College",
                    GameDate = DateTime.Parse("2025-3-8"),
                    Result = "Win",
                    HomeScore = 7,
                    OpponentScore = 4,
                    TicketPrice = 5.00M
                }

                
            );
            context.SaveChanges();
        }
    }
}