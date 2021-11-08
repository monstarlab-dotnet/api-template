using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Monstarlab.Templates.API.Infrastructure.Context;

namespace Monstarlab.Templates.API.Web
{
    public static class DI
    {
        public static void SetupDomainServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddOptions<MonstarlabAppSettings>()
                .Configure<IConfiguration>((settings, configuration) => configuration.Bind(settings));

            builder.Services.AddDbContext<MonstarlabDbContext>((s, options) =>
            {
                var settings = s.GetService<IOptions<MonstarlabAppSettings>>().Value;

                options.UseSqlServer(settings.DatabaseConnectionString);
            });
        }
    }
}
