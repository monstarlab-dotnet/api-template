using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Services;

public abstract class BaseService<TEntity> : IEntityService<TEntity> where TEntity : DomainEntity
{
    protected readonly IRepository<TEntity> Repository;

    public BaseService(IRepository<TEntity> repository)
    {
        Repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public Task<TEntity> GetAsync(Guid id) => Repository.GetAsync(id);

    public Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize) => Repository.GetAllAsync(page, pageSize);

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var (result, error) = await ValidateEntity(entity);

        if (!result)
            throw error;

        return await Repository.InsertAsync(entity);
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var (result, error) = await ValidateEntity(entity);

        if (!result)
            throw error;

        return await Repository.UpdateAsync(entity);
    }

    public Task DeleteAsync(Guid id) => Repository.DeleteAsync(id);

    protected abstract Task<(bool Result, Exception Error)> ValidateEntity(TEntity entity);
}

