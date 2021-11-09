﻿using Monstarlab.Templates.API.Domain.Models;

namespace Monstarlab.Templates.API.BusinessLogic.Interfaces
{
    public interface IEntityService<TEntity> where TEntity : DomainEntity
    {
        /// <summary>
        /// Get all entities
        /// </summary>
        /// <param name="page">Which page to fetch</param>
        /// <param name="pageSize">The size of each page</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize);

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
        Task DeleteAsync(Guid id);
    }
}
