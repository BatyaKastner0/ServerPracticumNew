using AutoMapper;
using Managment.API.Model;
using Managment.Core.Entities;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<EmployeePostModel, Employee>().ReverseMap();
        CreateMap<EmployeeRolePostModel, EmployeeRole>().ReverseMap();
        CreateMap<EmployeePostModel, Employee>()
.ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles)).ReverseMap();
        CreateMap<RolePostModel, Role>();
    }
}