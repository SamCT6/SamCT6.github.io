using System.ComponentModel.DataAnnotations;

namespace RazorPagesBaseball.Models;

public class Game
{
    public int Id { get; set; }
    public string? Opponent { get; set; }
    [DataType(DataType.Date)]
    public DateTime GameDate { get; set; }
    public string? Result { get; set; }
    public string? HomeScore { get; set; }
    public string? OpponentScore { get; set; }
    public decimal TicketPrice { get; set; }
}