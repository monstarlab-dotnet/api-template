﻿using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(MonstarlabDbContext context) : base(context)
        {
        }

        public Task<IEnumerable<Employee>> GetEmployeesAsync(int page, int pageSize) => GetAll<Employee>(Context.Employees, page, pageSize);
    }
}
