using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Services.EmployeeRole
{
    public class EmployeeRoleAppServices : IEmployeeRoleAppServices
    {
        Task<EmployeeRoleDto> IEmployeeRoleAppServices.addEmployeeRole(EmployeeRoleDto employeeRoleDto)
        {
            throw new System.NotImplementedException();
        }
    }

}
