using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Monstarlab.Templates.API.Web.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMapper Mapper;

        public BaseController(IMapper mapper)
        {
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
