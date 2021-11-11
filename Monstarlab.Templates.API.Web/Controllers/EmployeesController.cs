using AutoMapper;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Web.DTOs.Employee;

namespace Monstarlab.Templates.API.Web.Controllers
{
    public class EmployeesController : BaseController<Employee, EmployeeDto, EmployeeInsertDto, EmployeeUpdateDto>
    {
        public EmployeesController(IEntityService<Employee> entityService, IMapper mapper) : base(entityService, mapper)
        {
        }
    }
}
