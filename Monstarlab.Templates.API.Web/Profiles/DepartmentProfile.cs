namespace Monstarlab.Templates.API.Web.Profiles;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<Department, DepartmentDto>();

        CreateMap<DepartmentInsertDto, Department>();

        CreateMap<DepartmentUpdateDto, Department>();
    }
}
