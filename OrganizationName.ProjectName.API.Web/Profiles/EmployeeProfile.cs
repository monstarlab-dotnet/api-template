using OrganizationName.ProjectName.API.Web.DTOs.Employee;

namespace OrganizationName.ProjectName.API.Web.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDto>();

        CreateMap<EmployeeInsertDto, Employee>();

        CreateMap<EmployeeUpdateDto, Employee>();
    }
}
