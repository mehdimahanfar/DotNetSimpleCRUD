using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskManager.Entity.Foundation;
using TaskManager.Entity.Identity;
using TaskManager.Entity.TaskManager;

namespace TaskManager.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Branch> Branches { get; set; }
    
    public DbSet<Project> Projects { get; set; }
 
    // در بروز رسانی دیتابیس به مشکل خور
    // public DbSet<ProjectAccess> ProjectAccesses { get; set; }

    public DbSet<Ticket> Tickets { get; set; }
}