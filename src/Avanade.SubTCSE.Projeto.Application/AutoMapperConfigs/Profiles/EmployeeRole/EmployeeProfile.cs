using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.EmployeeRole.EmployeeRoleDto, Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Cargo));

            CreateMap<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, Dtos.EmployeeRole.EmployeeRoleDto>()
               .ForMember("roleCargo", opt => opt.MapFrom(src => src.RoleName));
        }
    }
}
