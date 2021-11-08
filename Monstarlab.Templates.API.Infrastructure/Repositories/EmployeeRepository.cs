using Microsoft.EntityFrameworkCore;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Context;

namespace Monstarlab.Templates.API.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(MonstarlabDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            var employees = await Context.Employees.Include(e => e.Department).ToListAsync();

            return employees;
        }
    }
}
