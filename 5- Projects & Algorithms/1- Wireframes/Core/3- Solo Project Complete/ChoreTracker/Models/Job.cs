#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChoreTracker.Models;
public class Job
{
    [Key]
    public int JobId { get; set; }

    [Required(ErrorMessage = "Title is required!")]
    [MinLength(2, ErrorMessage = "Title must be at least 2 characters")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Description is required!")]
    [MinLength(2, ErrorMessage = "Description must be at least 2 characters")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Location is required!")]
    [MinLength(2, ErrorMessage = "Location must be at least 2 characters")]
    public string Location { get; set; }

    [Required]
    [Display(Name = "Is it Urgent?")]
    public bool IsUrgent { get; set; }

    [Display(Name = "Due Date")]
    [DataType(DataType.DateTime)]
    [FutureDate]
    public DateTime DueDate { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // One to many join 
    public int UserId { get; set; }
    public User? Creator { get; set; }
    // Many to many join
    public List<Favorite> Favorites { get; set; } = new List<Favorite>();
}


public class FutureDateAttribute : ValidationAttribute
{
protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
            DateTime CurrentTime = DateTime.Now;
        if ((DateTime?)value < CurrentTime)
        {
            return new ValidationResult("Date must be in future!");
        } 
        else {
            return ValidationResult.Success;
        }
    }
}