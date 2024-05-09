using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Entity;
using TaskManager.Entity.Identity;

namespace TaskManager.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole, long>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}