using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories;

public class DepartmentRepository : BaseRepository<Department>
{
    public DepartmentRepository(MonstarlabDbContext context) : base(context)
    {
    }
}
