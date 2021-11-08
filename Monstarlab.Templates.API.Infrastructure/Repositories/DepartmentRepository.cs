using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Context;

namespace Monstarlab.Templates.API.Infrastructure.Repositories
{
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public DepartmentRepository(MonstarlabDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Department>> GetDepartmentsAsync(int page, int pageSize) => GetAll<Department>(Context.Departments, page, pageSize);
    }
}
