using TaskManager.Entity.Core;

namespace TaskManager.Entity.Foundation;

public class Branch : BaseEntity
{
    public string? Title { get; set; }
    
    public string? Description { get; set; }

    public Branch? Parent { get; set; }
}