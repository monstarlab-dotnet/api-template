namespace OrganizationName.ProjectName.API.Infrastructure.Data.Context;

public class MonstarlabDbContext : DbContext
{
    public MonstarlabDbContext([NotNull] DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    public DbSet<Department> Departments { get; set; }

    public DbSet<Employee> Employees { get; set; }
}
