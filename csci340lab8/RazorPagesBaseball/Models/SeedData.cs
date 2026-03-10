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
                    Opponent = "Westminster College",
                    GameDate = DateTime.Parse("2025-2-6"),
                    Result = "Win",
                    HomeScore = 16,
                    OpponentScore = 15,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "Westminster College",
                    GameDate = DateTime.Parse("2025-2-7"),
                    Result = "Win",
                    HomeScore = 12,
                    OpponentScore = 2,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "Westminster College",
                    GameDate = DateTime.Parse("2025-2-8"),
                    Result = "Loss",
                    HomeScore = 1,
                    OpponentScore = 5,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of St. Thomas",
                    GameDate = DateTime.Parse("2025-2-13"),
                    Result = "Loss",
                    HomeScore = 5,
                    OpponentScore = 9,
                    TicketPrice = 15.00M
                },
                new Game
                {
                    Opponent = "University of St. Thomas",
                    GameDate = DateTime.Parse("2025-2-13"),
                    Result = "Win",
                    HomeScore = 4,
                    OpponentScore = 3,
                    TicketPrice = 15.00M
                },
                new Game
                {
                    Opponent = "University of St. Thomas",
                    GameDate = DateTime.Parse("2025-2-12"),
                    Result = "Loss",
                    HomeScore = 0,
                    OpponentScore = 4,
                    TicketPrice = 15.00M
                },

                new Game
                {
                    Opponent = "University of the Ozarks",
                    GameDate = DateTime.Parse("2025-2-20"),
                    Result = "Win",
                    HomeScore = 7,
                    OpponentScore = 3,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of the Ozarks",
                    GameDate = DateTime.Parse("2025-2-21"),
                    Result = "Win",
                    HomeScore = 10,
                    OpponentScore = 1,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of the Ozarks",
                    GameDate = DateTime.Parse("2025-2-22"),
                    Result = "Win",
                    HomeScore = 11,
                    OpponentScore = 3,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of Redlands",
                    GameDate = DateTime.Parse("2025-2-27"),
                    Result = "Loss",
                    HomeScore = 11,
                    OpponentScore = 14,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of Redlands",
                    GameDate = DateTime.Parse("2025-2-27"),
                    Result = "Win",
                    HomeScore = 8,
                    OpponentScore = 5,
                    TicketPrice = 5.00M
                },

                new Game
                {
                    Opponent = "University of Redlands",
                    GameDate = DateTime.Parse("2025-2-28"),
                    Result = "Win",
                    HomeScore = 7,
                    OpponentScore = 4,
                    TicketPrice = 5.00M
                },
                new Game
                {
                    Opponent = "University of Redlands",
                    GameDate = DateTime.Parse("2025-3-1"),
                    Result = "Win",
                    HomeScore = 7,
                    OpponentScore = 5,
                    TicketPrice = 5.00M
                },
                new Game
                {
                    Opponent = "Centenary College",
                    GameDate = DateTime.Parse("2025-3-6"),
                    Result = "Win",
                    HomeScore = 12,
                    OpponentScore = 2,
                    TicketPrice = 5.00M
                },
                new Game
                {
                    Opponent = "Centenary College",
                    GameDate = DateTime.Parse("2025-3-7"),
                    Result = "Loss",
                    HomeScore = 7,
                    OpponentScore = 13,
                    TicketPrice = 5.00M
                },
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