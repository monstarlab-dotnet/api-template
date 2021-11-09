namespace Monstarlab.Templates.API.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
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
        Task<TEntity> InsertAsync(TEntity entity);
    }
}
