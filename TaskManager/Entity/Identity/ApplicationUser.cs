using Microsoft.AspNetCore.Identity;
using TaskManager.Entity.Foundation;

namespace TaskManager.Entity.Identity;

public class ApplicationUser : IdentityUser<long>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public Branch? Branch { get; set; }
}