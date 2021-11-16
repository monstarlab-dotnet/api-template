using Monstarlab.Templates.API.Web.DTOs.Department;

namespace Monstarlab.Templates.API.Web.Controllers;

public class DepartmentsController : BaseController<Department, Guid, DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto>
{
    public DepartmentsController(IEntityService<Department, Guid> entityService, IMapper mapper) : base(entityService, mapper)
    {
    }
}
