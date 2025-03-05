#pragma warning disable CS8618

namespace ChoreTracker.Models;

public class MyViewModel
{
    public User LoggedInUser { get; set; }
    public User User { get; set; }
    public List<User> AllUsers { get; set; }
    public Job Job { get; set; }
    public List<Job> AllJobs { get; set; }
    public bool IsFavorited { get; set; }

    public User UserWhoFavorited { get; set; }

}