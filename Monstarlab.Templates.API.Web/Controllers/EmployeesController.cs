using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Web.DTOs.Employee;

namespace Monstarlab.Templates.API.Web.Controllers
{
    [ApiVersion("1.0")]
    public class EmployeesController : BaseController
    {
        private readonly IEmployeeService EmployeeService;

        public EmployeesController(IMapper mapper, IEmployeeService employeeService) : base(mapper)
        {
            EmployeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAll()
        {
            var employees = await EmployeeService.GetAllEmployeesAsync();

            var mappedEmployees = Mapper.Map<IEnumerable<EmployeeDto>>(employees);

            return new OkObjectResult(mappedEmployees);
        }
    }
}
