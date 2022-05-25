namespace OrganizationName.ProjectName.API.Infrastructure.Data.Configurations;

internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    internal static Guid AarhusId = new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3");
    internal static Guid CopenhagenId = new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b");

    public void Configure(EntityTypeBuilder<Department> builder)
    {
        var aarhus = new Department
        {
            Id = AarhusId,
            City = "Aarhus",
            Country = "Denmark",
            Floor = "9",
            Number = "2F",
            Street = "Mariane Thomsens Gade",
            ZipCode = "8000"
        };
        var copenhagen = new Department
        {
            Id = CopenhagenId,
            City = "Copenhagen",
            Country = "Denmark",
            Street = "Orientkaj",
            Number = "4",
            ZipCode = "2150"
        };

        builder.HasData(new[]
            {
                aarhus,
                copenhagen
            });
    }
}
