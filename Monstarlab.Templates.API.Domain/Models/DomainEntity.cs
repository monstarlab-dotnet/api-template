namespace Monstarlab.Templates.API.Domain.Models;

public abstract class DomainEntity
{
    [Key]
    public Guid Id { get; set; }
}
