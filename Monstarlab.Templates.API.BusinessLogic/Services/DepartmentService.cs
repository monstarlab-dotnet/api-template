using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public class DepartmentService : BaseService<Department>
    {
        public DepartmentService(IRepository<Department> repository) : base(repository)
        {
        }

        protected override Task<(bool Result, string ErrorMessage)> ValidateEntity(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
