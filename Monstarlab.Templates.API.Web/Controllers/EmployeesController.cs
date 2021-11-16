using Monstarlab.Templates.API.Web.DTOs.Employee;

namespace Monstarlab.Templates.API.Web.Controllers;

public class EmployeesController : BaseController<Employee, Guid, EmployeeDto, EmployeeInsertDto, EmployeeUpdateDto>
{
    public EmployeesController(IEntityService<Employee, Guid> entityService, IMapper mapper) : base(entityService, mapper)
    {
    }
}
