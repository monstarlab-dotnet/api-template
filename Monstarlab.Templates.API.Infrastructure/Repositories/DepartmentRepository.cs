using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Department>> GetDepartmentsAsync()
        {
            var departments = await Context.Departments.ToListAsync();

            return departments;
        }
    }
}
