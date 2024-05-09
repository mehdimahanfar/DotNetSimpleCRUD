using Microsoft.AspNetCore.Identity;

namespace TaskManager.Entity.Identity;

public class ApplicationUser : IdentityUser<long>
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
}