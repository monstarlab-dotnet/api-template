using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public class EmployeeService : BaseService<Employee>
    {
        public EmployeeService(IRepository<Employee> repository) : base(repository)
        {
        }

        protected override Task<(bool Result, string ErrorMessage)> ValidateEntity(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
