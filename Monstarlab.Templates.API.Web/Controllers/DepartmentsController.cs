using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Web.DTOs.Department;

namespace Monstarlab.Templates.API.Web.Controllers
{
    [ApiVersion("1.0")]
    public class DepartmentsController : BaseController
    {
        private readonly IDepartmentService DepartmentService;

        public DepartmentsController(IDepartmentService departmentService, IMapper mapper) : base(mapper)
        {
            DepartmentService = departmentService ?? throw new ArgumentNullException(nameof(departmentService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAll()
        {
            var departments = await DepartmentService.GetAllDepartmentsAsync();

            var mappedDepartments = Mapper.Map<IEnumerable<DepartmentDto>>(departments);

            return new OkObjectResult(mappedDepartments);
        }
    }
}
