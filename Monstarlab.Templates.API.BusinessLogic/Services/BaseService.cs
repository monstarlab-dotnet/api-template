namespace Monstarlab.Templates.API.BusinessLogic.Services;

public abstract class BaseService<TEntity, TId> : IEntityService<TEntity, TId> where TEntity : EntityBase<TId>
{
    protected readonly IEntityRepository<TEntity, TId> Repository;

    public BaseService(IEntityRepository<TEntity, TId> repository)
    {
        Repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public Task<TEntity> GetAsync(TId id) => Repository.GetAsync(id);

    public Task<ListWrapper<TEntity>> GetAllAsync(int page, int pageSize) => Repository.GetListAsync(page, pageSize);

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var (result, error) = await ValidateEntity(entity);

        if (!result)
            throw error;

        return await Repository.AddAsync(entity);
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

    public Task DeleteAsync(TId id) => Repository.DeleteAsync(id);

    protected abstract Task<(bool Result, Exception Error)> ValidateEntity(TEntity entity);
}

