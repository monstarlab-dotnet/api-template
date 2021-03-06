namespace Monstarlab.Templates.API.BusinessLogic.Services;

public class DepartmentService : BaseService<Department, Guid>
{
    public DepartmentService(IEntityRepository<Department, Guid> repository) : base(repository)
    {
    }

    protected override Task<(bool Result, Exception Error)> ValidateEntity(Department entity)
    {
        if (string.IsNullOrWhiteSpace(entity.City))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.City)) as Exception));

        if (string.IsNullOrWhiteSpace(entity.Country))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.Country)) as Exception));

        if (string.IsNullOrWhiteSpace(entity.ZipCode))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.ZipCode)) as Exception));

        if (string.IsNullOrWhiteSpace(entity.Street))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.Street)) as Exception));

        if (string.IsNullOrWhiteSpace(entity.Number))
            return Task.FromResult((false, new ArgumentNullException(nameof(entity.Number)) as Exception));

        return Task.FromResult((true, null as Exception));
    }
}
