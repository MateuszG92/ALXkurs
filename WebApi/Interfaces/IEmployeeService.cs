using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeDTO employeeDTO);
    }
}
