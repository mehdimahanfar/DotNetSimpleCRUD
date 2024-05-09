using TaskManager.Entity.Core;
using TaskManager.Entity.Foundation;
using TaskManager.Entity.Identity;

namespace TaskManager.Entity.TaskManager;

public class ProjectAccess : BaseEntity
{
    public Project Project { get; set; }

    public ApplicationUser User { get; set; }
}