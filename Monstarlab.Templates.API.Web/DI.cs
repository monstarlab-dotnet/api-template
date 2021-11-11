using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Monstarlab.Templates.API.BusinessLogic.Interfaces;
using Monstarlab.Templates.API.BusinessLogic.Services;
using Monstarlab.Templates.API.Domain.Interfaces;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Infrastructure.Data.Context;
using Monstarlab.Templates.API.Infrastructure.Data.Repositories;

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
        services.AddTransient<IRepository<Department>, DepartmentRepository>();
        services.AddTransient<IRepository<Employee>, EmployeeRepository>();
    }

    private static void SetupServices(this IServiceCollection services)
    {
        services.AddTransient<IEntityService<Department>, DepartmentService>();
        services.AddTransient<IEntityService<Employee>, EmployeeService>();
    }
}
