﻿namespace OrganizationName.ProjectName.API.BusinessLogic.Services;

public class EmployeeService : BaseService<Employee, Guid>
{
    public EmployeeService(IEntityRepository<Employee, Guid> repository) : base(repository)
    {
    }

    protected override Task<(bool Result, Exception Error)> ValidateEntity(Employee entity)
    {
        if (string.IsNullOrWhiteSpace(entity.FirstName))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.FirstName)) as Exception));

        if (string.IsNullOrWhiteSpace(entity.LastName))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.LastName)) as Exception));

        if (entity.DepartmentId.Equals(Guid.Empty))
            return Task.FromResult((false, new ArgumentException("Department ID was not set", nameof(entity.DepartmentId)) as Exception));

        return Task.FromResult((true, null as Exception));
    }
}
