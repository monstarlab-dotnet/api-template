namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories;

public class EmployeeRepository : EntityRepository<MonstarlabDbContext, Employee, Guid>
{
    public EmployeeRepository(MonstarlabDbContext context) : base(context)
    {
    }

    protected override IQueryable<Employee> BaseIncludes()
    {
        var query = base.BaseIncludes();

        return query.Include(e => e.Department);
    }
}
