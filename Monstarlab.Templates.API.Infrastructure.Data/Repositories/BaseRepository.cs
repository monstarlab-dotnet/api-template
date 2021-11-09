using Microsoft.EntityFrameworkCore;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MonstarlabDbContext Context;

        protected BaseRepository(MonstarlabDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize)
        {
            if (page < 1)
                throw new ArgumentOutOfRangeException(nameof(page), page, "Value should be 1 or higher");

            if (pageSize < 1)
                throw new ArgumentOutOfRangeException(nameof(pageSize), pageSize, "Value should be 1 or higher");


            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (page > 1)
                query = query.Skip((page - 1) * pageSize);

            query = query.Take(pageSize);

            return await query.ToListAsync();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var AddedEntity = Context.Add(entity);

            await Context.SaveChangesAsync();

            return AddedEntity.Entity;
        }
    }
}
