namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories;

public class EmployeeRepository : BaseRepository<Employee>
{
    public EmployeeRepository(MonstarlabDbContext context) : base(context)
    {
    }

    protected override IQueryable<Employee> WithIncludes()
    {
        var query = base.WithIncludes();

        return query.Include(e => e.Department);
    }
}
