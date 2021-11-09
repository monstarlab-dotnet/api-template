using Monstarlab.Templates.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monstarlab.Templates.API.BusinessLogic.Interfaces
{
    public interface IEmployeeService
    {
        /// <summary>
        /// Get all employees
        /// </summary>
        /// <param name="page">Which page to fetch</param>
        /// <param name="pageSize">The size of each page</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        Task<IEnumerable<Employee>> GetAllEmployeesAsync(int page, int pageSize);
    }
}
