using AutoMapper;
using Monstarlab.Templates.API.Domain.Models;
using Monstarlab.Templates.API.Web.DTOs.Employee;

namespace Monstarlab.Templates.API.Web.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>();
        }
    }
}
