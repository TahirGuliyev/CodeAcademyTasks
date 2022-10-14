using System.ComponentModel.DataAnnotations;

namespace BookTask.Domain.Common;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
}