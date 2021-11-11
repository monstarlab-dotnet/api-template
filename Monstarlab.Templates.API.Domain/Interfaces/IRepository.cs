using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : DomainEntity
{
    /// <summary>
    /// Get entity with given <paramref name="id"/>
    /// </summary>
    /// <param name="id">The ID of the entity to fetch</param>
    /// <exception cref="ArgumentException"></exception>
    Task<TEntity> GetAsync(Guid id);

    /// <summary>
    /// Get all entities in the database
    /// </summary>
    /// <param name="page">Which page to fetch</param>
    /// <param name="pageSize">The size of each page</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize);

    /// <summary>
    /// Insert new entity into the database
    /// </summary>
    /// <param name="entity">The entity to insert</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="ArgumentException"></exception>
    Task<TEntity> InsertAsync(TEntity entity);

    /// <summary>
    /// Delete the entity with the given <paramref name="id"/>
    /// </summary>
    /// <param name="id">The ID of the entity to delete</param>
    /// <exception cref="ArgumentException"></exception>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// Update the entity
    /// </summary>
    /// <param name="entity">Entity to update</param>
    /// <exception cref="ArgumentNullException"></exception>
    Task<TEntity> UpdateAsync(TEntity entity);
}
