using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository Repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync(int page, int pageSize)
        {
            var departments = await Repository.GetDepartmentsAsync(page, pageSize);

            return departments;
        }
    }
}
