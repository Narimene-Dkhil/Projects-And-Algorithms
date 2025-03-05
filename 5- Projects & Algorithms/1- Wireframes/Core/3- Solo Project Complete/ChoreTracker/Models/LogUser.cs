#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChoreTracker.Models;
public class LogUser
{
    [Required(ErrorMessage ="Email address is required")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LogEmail { get; set; }
    
    [Required(ErrorMessage ="Password is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LogPassword { get; set; }
}