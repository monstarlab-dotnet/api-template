namespace Monstarlab.Templates.API.Infrastructure.Data.Repositories;

public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : DomainEntity
{
    protected readonly MonstarlabDbContext Context;

    protected BaseRepository(MonstarlabDbContext context)
    {
        Context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<TEntity> GetAsync(Guid id)
    {
        if (id.Equals(Guid.Empty))
            throw new ArgumentException("ID was not set", nameof(id));

        var entity = await WithIncludes().FirstOrDefaultAsync(e => e.Id.Equals(id));

        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(int page, int pageSize)
    {
        if (page < 1)
            throw new ArgumentOutOfRangeException(nameof(page), page, "Value should be 1 or higher");

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize), pageSize, "Value should be 1 or higher");


        IQueryable<TEntity> query = WithIncludes();

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

        return await WithIncludes().FirstAsync(e => e.Id.Equals(AddedEntity.Entity.Id));
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetAsync(id);

        if (entity == null)
            return;

        Context.Set<TEntity>().Remove(entity);

        await Context.SaveChangesAsync();
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity));

        var updatedEntity = Context.Set<TEntity>().Update(entity);

        await Context.SaveChangesAsync();

        return await GetAsync(updatedEntity.Entity.Id);
    }

    protected virtual IQueryable<TEntity> WithIncludes()
    {
        return Context.Set<TEntity>();
    }
}
