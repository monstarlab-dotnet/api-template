using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(MonstarlabDbContext context) : base(context)
        {
        }
    }
}
