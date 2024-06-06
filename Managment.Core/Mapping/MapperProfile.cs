using AutoMapper;
using Managment.Core.DTO;
using Managment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Core.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

             CreateMap<Employee, EmployeeDTO>().ReverseMap();

           // CreateMap<EmployeeDTO, Employee>() ;
            CreateMap<EmployeeRole, EmployeeRoleDTO>();
            //CreateMap<IEnumerable<Employee>, IEnumerable<EmployeeDTO>>().ReverseMap();

            //.ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles))
            //.ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            //.ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            //.ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
            //.ForMember(dest => dest.Tz, opt => opt.MapFrom(src => src.Tz));

            // CreateMap<List<Employee>, IEnumerable<EmployeeDTO>>();
            CreateMap<Role, RoleDTO>().ReverseMap();


            //        public DateTime DateBorn { get; set; }
            // public bool IsMale { get; set; }
        }

    }
}
