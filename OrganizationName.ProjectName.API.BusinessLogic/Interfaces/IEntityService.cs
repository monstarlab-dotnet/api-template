namespace OrganizationName.ProjectName.API.BusinessLogic.Interfaces;

public interface IEntityService<TEntity, TId> where TEntity : EntityBase<TId>
{
    /// <summary>
    /// Get entity with given <paramref name="id"/>
    /// </summary>
    /// <param name="id">The ID of the entity to fetch</param>
    /// <exception cref="ArgumentException"></exception>
    Task<TEntity> GetAsync(TId id);

    /// <summary>
    /// Get all entities
    /// </summary>
    /// <param name="page">Which page to fetch</param>
    /// <param name="pageSize">The size of each page</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    Task<ListWrapper<TEntity>> GetAllAsync(int page, int pageSize, Expression<Func<TEntity, bool>>[]? filters = null);

    /// <summary>
    /// Insert new entity
    /// </summary>
    /// <param name="entity">The entity to insert/add</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    Task<TEntity> InsertAsync(TEntity entity);

    /// <summary>
    /// Delete the entity with the given <paramref name="id"/>
    /// </summary>
    /// <param name="id">The ID of the entity to delete</param>
    /// <exception cref="ArgumentException"></exception>
    Task DeleteAsync(TId id);

    /// <summary>
    /// Update the entity
    /// </summary>
    /// <param name="entity">Entity to update</param>
    /// <exception cref="ArgumentNullException"></exception>
    Task<TEntity> UpdateAsync(TEntity entity);
}
