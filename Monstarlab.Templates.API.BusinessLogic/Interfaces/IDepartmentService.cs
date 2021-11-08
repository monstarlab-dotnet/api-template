using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    }
}
