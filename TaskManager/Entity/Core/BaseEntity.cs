using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TaskManager.Entity.Identity;

namespace TaskManager.Entity.Core;

public class BaseEntity
{
    [Key]
    public long Id { get; set; }
    public Guid Guid { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime DeletedAt { get; set; }

    public long? CreatedBy { get; set; }
    public long? UpdateBy { get; set; }
    public long? DeletedBy { get; set; }
}