using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using System.Net;

namespace Monstarlab.Templates.API.Web.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public abstract class BaseController<TEntity, TDto, TInsertDto, TUpdateDto> : ControllerBase where TEntity : DomainEntity where TDto : class where TInsertDto : class where TUpdateDto : class
    {
        protected readonly IEntityService<TEntity> EntityService;
        protected readonly IMapper Mapper;

        public BaseController(IEntityService<TEntity> entityService, IMapper mapper)
        {
            EntityService = entityService ?? throw new ArgumentNullException(nameof(entityService));
            Mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public virtual async Task<ActionResult<TDto>> Get(Guid id)
        {
            var entity = await EntityService.GetAsync(id);

            if (entity == null)
                return NotFound();

            var mappedEntity = Mapper.Map<TDto>(entity);

            return new OkObjectResult(mappedEntity);
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TDto>>> GetAll(int page = 1, int pageSize = 20)
        {
            var entities = await EntityService.GetAllAsync(page, pageSize);

            var mappedEntities = Mapper.Map<IEnumerable<TDto>>(entities);

            return new OkObjectResult(mappedEntities);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<ActionResult<TDto>> Insert(TInsertDto dto)
        {
            var mappedEntity = Mapper.Map<TEntity>(dto);

            var insertedEntity = await EntityService.InsertAsync(mappedEntity);

            var returnEntity = Mapper.Map<TDto>(insertedEntity);

            return new OkObjectResult(returnEntity);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public virtual async Task<ActionResult<TDto>> Update(Guid id, TUpdateDto dto)
        {
            if (id == Guid.Empty)
                return new BadRequestObjectResult($"{nameof(id)} was not set");

            if (dto == null)
                return new BadRequestObjectResult("No body was set");

            var mappedEntity = Mapper.Map<TEntity>(dto);

            mappedEntity.Id = id;

            var updatedEntity = await EntityService.UpdateAsync(mappedEntity);

            var returnDto = Mapper.Map<TDto>(updatedEntity);

            return new OkObjectResult(returnDto);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            await EntityService.DeleteAsync(id);

            return new NoContentResult();
        }
    }
}
