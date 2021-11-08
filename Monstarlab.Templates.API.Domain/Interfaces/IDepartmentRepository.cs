using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.Domain.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> GetDepartmentsAsync();
    }
}
