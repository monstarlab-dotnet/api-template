using Monstarlab.Templates.API.Infrastructure.Context;

namespace Monstarlab.Templates.API.Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly MonstarlabDbContext Context;

        protected BaseRepository(MonstarlabDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
