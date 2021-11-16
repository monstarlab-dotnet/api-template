namespace Monstarlab.Templates.API.Web.DTOs.Employee;

public class EmployeeUpdateDto
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public uint? Age { get; set; }

    public Guid? DepartmentId { get; set; }
}
