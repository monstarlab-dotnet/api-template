using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Interfaces;

namespace Monstarlab.Templates.API.BusinessLogic.Services
{
    public abstract class BaseService<TEntity> : IEntityService<TEntity> where TEntity : class
    {
        protected readonly IRepository<TEntity> Repository;

        public BaseService(IRepository<TEntity> repository)
        {
            Repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize) => Repository.GetAllAsync(page, pageSize);

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var validation = await ValidateEntity(entity);

            if (!validation.Result)
                throw new ArgumentException(validation.ErrorMessage, nameof(entity));

            return await Repository.InsertAsync(entity);
        }

        protected abstract Task<(bool Result, string ErrorMessage)> ValidateEntity(TEntity entity);
    }
}
