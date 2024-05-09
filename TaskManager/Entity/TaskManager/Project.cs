using TaskManager.Entity.Core;
using TaskManager.Entity.Identity;

namespace TaskManager.Entity.TaskManager;

public class Project : BaseEntity
{
    public ApplicationUser Manager { get; set; }

    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public string Color { get; set; }
    
    public List<string> SubjectList { get; set; }
}