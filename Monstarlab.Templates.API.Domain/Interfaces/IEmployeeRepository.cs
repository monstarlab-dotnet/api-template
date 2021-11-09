using Monstarlab.Templates.API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monstarlab.Templates.API.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Get all employees in the database
        /// </summary>
        /// <param name="page">Which page to fetch</param>
        /// <param name="pageSize">The size of each page</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        Task<IEnumerable<Employee>> GetEmployeesAsync(int page, int pageSize);
    }
}
