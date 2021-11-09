using AutoMapper;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Web.DTOs.Department;

namespace Monstarlab.Templates.API.Web.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDto>();

            CreateMap<DepartmentInsertDto, Department>();
        }
    }
}
