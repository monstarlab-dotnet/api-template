using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Interfaces
{
    public interface IDepartmentService
    {
        /// <summary>
        /// Get all departments
        /// </summary>
        /// <param name="page">Which page to fetch</param>
        /// <param name="pageSize">The size of each page</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        Task<IEnumerable<Department>> GetAllDepartmentsAsync(int page, int pageSize);
    }
}
