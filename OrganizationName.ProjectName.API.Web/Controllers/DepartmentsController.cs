namespace OrganizationName.ProjectName.API.Web.Controllers;

public class DepartmentsController : BaseController<Department, Guid, DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto>
{
    public DepartmentsController(IEntityService<Department, Guid> entityService, IMapper mapper) : base(entityService, mapper)
    {
    }

    [HttpGet]
    public Task<ActionResult<ListWrapper<DepartmentDto>>> GetList(int page = 1, int pageSize = 20) => GetAll(page, pageSize);
}
