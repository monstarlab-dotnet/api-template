using Microsoft.EntityFrameworkCore;
using Monstarlab.Templates.API.Domain.Models;
using System.Diagnostics.CodeAnalysis;

namespace Monstarlab.Templates.API.Infrastructure.Context
{
    public class MonstarlabDbContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MonstarlabDbContext([NotNull] DbContextOptions options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}