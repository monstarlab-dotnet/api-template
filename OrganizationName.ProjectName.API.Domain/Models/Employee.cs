namespace OrganizationName.ProjectName.API.Domain.Models;

public class Employee : EntityBase<Guid>
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    [Required]
    public uint? Age { get; set; }

    [Required]
    public Guid? DepartmentId { get; set; }

    public Department Department { get; set; }
}
