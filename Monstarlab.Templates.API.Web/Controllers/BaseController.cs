using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;

namespace Monstarlab.Templates.API.Web.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public abstract class BaseController<TEntity, TDto> : ControllerBase where TEntity : class where TDto : class
    {
        protected readonly IEntityService<TEntity> EntityService;
        protected readonly IMapper Mapper;

        public BaseController(IEntityService<TEntity> entityService, IMapper mapper)
        {
            EntityService = entityService ?? throw new ArgumentNullException(nameof(entityService));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll(int page = 1, int pageSize = 20)
        {
            var entities = await EntityService.GetAllAsync(page, pageSize);

            var mappedEntities = Mapper.Map<IEnumerable<TDto>>(entities);

            return new OkObjectResult(mappedEntities);
        }
    }
}
