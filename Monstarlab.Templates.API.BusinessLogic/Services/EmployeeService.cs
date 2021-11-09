using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        protected readonly IEmployeeRepository EmployeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(int page, int pageSize)
        {
            var employees = await EmployeeRepository.GetEmployeesAsync(page, pageSize);

            return employees;
        }
    }
}
