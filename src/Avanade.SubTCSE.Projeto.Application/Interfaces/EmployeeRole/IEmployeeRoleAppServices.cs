using Avanade.SubTCSE.Projeto.Application.Dtos.EmployeeRole;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.EmployeeRole
{
    public interface IEmployeeRoleAppServices
    {
        Task<EmployeeRoleDto> addEmployeeRole(EmployeeRoleDto employeeRoleDto);
    }
}
