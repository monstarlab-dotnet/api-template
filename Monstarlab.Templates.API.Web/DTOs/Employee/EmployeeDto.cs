﻿namespace Monstarlab.Templates.API.Web.DTOs.Employee;

public class EmployeeDto : DomainDto
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string FullName => $"{FirstName} {LastName}";

    public uint Age { get; set; }

    public DepartmentDto Department { get; set; }
}
