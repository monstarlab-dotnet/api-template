using Monstarlab.Templates.API.Web.DTOs.Employee;

namespace Monstarlab.Templates.API.Web.Controllers;

public class EmployeesController : BaseController<Employee, Guid, EmployeeDto, EmployeeInsertDto, EmployeeUpdateDto>
{
    public EmployeesController(IEntityService<Employee, Guid> entityService, IMapper mapper) : base(entityService, mapper)
    {
    }

    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public async Task<ActionResult<ListWrapper<EmployeeDto>>> GetAll(int page = 1, int pageSize = 20, Guid? departmentId = null)
    {
        var employees = await EntityService.GetAllAsync(page, pageSize, departmentId != null ? new Expression<Func<Employee, bool>>[] { f => f.DepartmentId == departmentId } : null);

        var mappedEntities = new ListWrapper<EmployeeDto>
        {
            Data = Mapper.Map<IEnumerable<EmployeeDto>>(employees.Data),
            Meta = employees.Meta
        };

        return new OkObjectResult(mappedEntities);
    }
}
