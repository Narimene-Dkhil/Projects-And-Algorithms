#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChoreTracker.Models;
public class User
{
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "First Name is required!")]
    [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required!")]
    [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email address is required!")]
    [EmailAddress]
    [UniqueEmail]
    public string Email { get; set; }


    [Required(ErrorMessage = "Password is required!")]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    [DataType(DataType.Password)] 
    public string Password { get; set; }

    //Not mapped Confirm Password
    [NotMapped]
    [Required(ErrorMessage = "Confirm Password is required!")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Password & Confirm Password not matching!")]
    [Display(Name = "Confirm Password")]
    public string Confirm { get; set; }

    [Required]
    [Display(Name = "Are you a Doctor?")]
    public bool IsDoctor { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // One to Many join
    public List<Job> AllJobs { get; set; } = new List<Job>();
    // Many to many join
    public List<Favorite> Favorites { get; set; } = new List<Favorite>();

}

public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Email is required!");
        }

        MyContext? _context = validationContext.GetService(typeof(MyContext)) as MyContext;
        if (_context == null)
        {
            throw new InvalidOperationException("MyContext is not available.");
        }

        if (_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email must be unique!");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}

