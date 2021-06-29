using AutoMapper;

namespace Avanade.SubTCSE.Projeto.Application.AutoMapperConfigs.Profiles.Employee
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Dtos.Employee.EmployeeDto, Domain.Aggregates.Employee.Entities.Employee>()
                .ConstructUsing((ctor, res) =>
                {
                    return new Domain.Aggregates.Employee.Entities.Employee(
                        firstName: ctor.PrimeiroNome,
                        surname: ctor.Sobrenome,
                        birth: ctor.Aniversario,
                        salary: ctor.Salario,
                        active: ctor.Ativo,
                        employeeRole: res.Mapper.Map<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>(ctor.Cargo));
                })
                .ForAllMembers(i => i.Ignore());

            CreateMap<Domain.Aggregates.Employee.Entities.Employee, Dtos.Employee.EmployeeDto>()
               .ForMember(epy => epy.Identificador, opt => opt.MapFrom(src => src.Id))
               .ForMember(epy => epy.PrimeiroNome, opt => opt.MapFrom(src => src.FirstName))
               .ForMember(epy => epy.Sobrenome, opt => opt.MapFrom(src => src.Surname))
               .ForMember(epy => epy.Aniversario, opt => opt.MapFrom(src => src.Birth))
               .ForMember(epy => epy.Ativo, opt => opt.MapFrom(src => src.Active))
               .ForMember(epy => epy.Salario, opt => opt.MapFrom(src => src.Salary))
               .ForMember(epy => epy.Cargo, opt => opt.MapFrom(src => src.employeeRole))
               .ForAllMembers(i => i.Ignore());
        }
    }
}
