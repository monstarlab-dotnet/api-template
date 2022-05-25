namespace OrganizationName.ProjectName.API.Infrastructure.Data.Repositories;

public class EmployeeRepository : EntityRepository<ProjectNameDbContext, Employee, Guid>
{
    public EmployeeRepository(ProjectNameDbContext context) : base(context)
    {
    }

    protected override IQueryable<Employee> BaseIncludes()
    {
        var query = base.BaseIncludes();

        return query.Include(e => e.Department);
    }
}
