#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChoreTracker.Models;

public class Favorite
{
    [Key]
    public int FavoriteId { get; set; }

    [Required]
    public int UserId { get; set; }
    [Required]
    public int JobId { get; set; }

    public User? User { get; set; }
    public Job? Job { get; set; }
}