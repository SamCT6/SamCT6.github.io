using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBaseball.Models;

public class Game
{
    public int Id { get; set; }
    public string? Opponent { get; set; }
    [Display(Name = "Game Date")]
    [DataType(DataType.Date)]
    public DateTime GameDate { get; set; }
    public string? Result { get; set; }
    public int HomeScore { get; set; }
    public int OpponentScore { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TicketPrice { get; set; }
}