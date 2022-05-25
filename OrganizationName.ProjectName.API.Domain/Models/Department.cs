namespace OrganizationName.ProjectName.API.Domain.Models;

public class Department : EntityBase<Guid>
{
    [Required]
    public string Country { get; set; }

    [Required]
    public string ZipCode { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string Street { get; set; }

    [Required]
    public string Number { get; set; }

    public string? Floor { get; set; }

    public string? Apartment { get; set; }

    public IEnumerable<Employee> Employees { get; set; }
}
