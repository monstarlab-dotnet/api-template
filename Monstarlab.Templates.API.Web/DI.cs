namespace Monstarlab.Templates.API.Web;

public static class DI
{
    public static void SetupDomainServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOptions<MonstarlabAppSettings>()
            .Configure<IConfiguration>((settings, configuration) => configuration.Bind(settings));

        builder.Services.AddAutoMapper(a => a.AllowNullCollections = true, typeof(DI).Assembly);

        builder.Services.AddDbContext<MonstarlabDbContext>((s, options) =>
        {
            var settings = s.GetService<IOptions<MonstarlabAppSettings>>()?.Value ?? throw new ArgumentNullException();

            options.UseSqlServer(settings.DatabaseConnectionString);
        });

        builder.Services.SetupRepositories();

        builder.Services.SetupServices();
    }

    private static void SetupRepositories(this IServiceCollection services)
    {
        services.AddTransient<IEntityRepository<Department, Guid>, EntityRepository<MonstarlabDbContext, Department, Guid>>();
        services.AddTransient<IEntityRepository<Employee, Guid>, EmployeeRepository>();
    }

    private static void SetupServices(this IServiceCollection services)
    {
        services.AddTransient<IEntityService<Department, Guid>, DepartmentService>();
        services.AddTransient<IEntityService<Employee, Guid>, EmployeeService>();
    }
}
