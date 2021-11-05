using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees { get; set; }
    }
}
