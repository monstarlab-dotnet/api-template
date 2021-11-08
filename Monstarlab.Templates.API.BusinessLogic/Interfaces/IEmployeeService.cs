using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
    }
}
