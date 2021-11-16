namespace Monstarlab.Templates.API.Domain.Models;

public class Employee : EntityBase<Guid>
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public uint Age { get; set; }

    public Guid DepartmentId { get; set; }

    public Department Department { get; set; }
}
