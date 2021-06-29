using Avanade.SubTCSE.Projeto.Application.Dtos.Employee;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Application.Interfaces.Employee
{
    public interface IEmployeeAppServices
    {
        Task<EmployeeDto> addEmployee(EmployeeDto employeeDto);
    }
}
