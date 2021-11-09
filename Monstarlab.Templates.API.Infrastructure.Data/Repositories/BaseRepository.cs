using Microsoft.EntityFrameworkCore;
using Monstarlab.Templates.API.Infrastructure.Data.Context;

namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly MonstarlabDbContext Context;

        protected BaseRepository(MonstarlabDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected async Task<IEnumerable<T>> GetAll<T>(IQueryable<T> query, int page, int pageSize) where T : class
        {
            if (page < 1)
                throw new ArgumentOutOfRangeException(nameof(page), page, "Value should be 1 or higher");

            if(pageSize < 1)
                throw new ArgumentOutOfRangeException(nameof(pageSize), pageSize, "Value should be 1 or higher");


            if (page > 1)
                query = query.Skip((page - 1) * pageSize);

            query = query.Take(pageSize);

            return await query.ToListAsync();
        }
    }
}
