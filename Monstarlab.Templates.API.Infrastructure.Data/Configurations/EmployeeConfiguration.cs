namespace Monstarlab.Templates.API.Infrastructure.Data.Configurations;

internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
            .HasOne<Department>(e => e.Department)
            .WithMany(d => d.Employees)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasData(new[]
            {
                new Employee
                {
                    Id = new Guid("efb8f31e-cdd3-4d6b-96a3-3ee6fe9ae679"),
                    FirstName = "Morten",
                    LastName = "Turn Pedersen",
                    Age = 32,
                    DepartmentId = DepartmentConfiguration.AarhusId
                },
                new Employee
                {
                    Id = new Guid("35607bf7-9a00-489d-bf71-bbdb53f2f7d8"),
                    FirstName = "Morten",
                    LastName = "Pløger",
                    Age = 29,
                    DepartmentId = DepartmentConfiguration.AarhusId
                },
                new Employee
                {
                    Id = new Guid("fa4b4f52-0c8b-4839-bbc1-d33a9bf2ca38"),
                    FirstName = "Kasper",
                    LastName = "Welner",
                    Age = 31,
                    DepartmentId = DepartmentConfiguration.CopenhagenId
                }
            });
    }
}
