using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public class EmployeeService : IEmployeeService
    {
        protected readonly IEmployeeRepository EmployeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            EmployeeRepository = employeeRepository ?? throw new ArgumentNullException(nameof(employeeRepository));
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            var employees = await EmployeeRepository.GetEmployeesAsync();

            return employees;
        }
    }
}
