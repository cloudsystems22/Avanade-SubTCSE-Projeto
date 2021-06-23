using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    public interface IEmployeeRoleService
    {
        Task<EmployeeRole.Entities.EmployeeRole> addEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
