
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesBaseball.Models;

public class Game
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Opponent { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [Required]
    public DateTime GameDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string Result { get; set; } = string.Empty;

    [Required]
    public int HomeScore { get; set; }

    [Required]
    public int OpponentScore { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal TicketPrice { get; set; }

}