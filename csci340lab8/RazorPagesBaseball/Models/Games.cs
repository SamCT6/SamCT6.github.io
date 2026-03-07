using System.ComponentModel.DataAnnotations;

namespace RazorPagesBaseball.Models;

public class Games
{
    public int Id { get; set; }
    public string? Opponets { get; set; }
    [DataType(DataType.Date)]
    public DateTime GameDate { get; set; }
    public string? WinOrLoss { get; set; }
    public int HomeScore { get; set; }
    public int AwayScore { get; set; }

}