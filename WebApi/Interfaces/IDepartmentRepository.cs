using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IDepartmentRepository:IRepository<Department>
    {
         Task<Department> GetByName(string departmentName);
    }
}
