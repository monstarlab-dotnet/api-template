using AutoMapper;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Web.DTOs.Department;

namespace Monstarlab.Templates.API.Web.Controllers
{
    public class DepartmentsController : BaseController<Department, DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto>
    {
        public DepartmentsController(IEntityService<Department> entityService, IMapper mapper) : base(entityService, mapper)
        {
        }
    }
}
