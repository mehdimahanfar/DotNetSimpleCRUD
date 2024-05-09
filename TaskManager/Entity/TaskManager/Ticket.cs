using TaskManager.Entity.Core;
using TaskManager.Entity.Identity;
using TaskManager.Enum;

namespace TaskManager.Entity.TaskManager;

public class Ticket : BaseEntity
{
    public string Title { get; set; }
    
    public string Subject { get; set; }
    
    public string Description { get; set; }
    
    // public ApplicationUser Owner { get; set; }
    
    public Project Project { get; set; }
    
    // public ApplicationUser Reporter { get; set; }
    
    public DateTime DeadLine { get; set; }
    
    public List<string> Label { get; set; }
    
    public TicketPriority Priority { get; set; }
    
    public DateTime Reminder { get; set; }
}