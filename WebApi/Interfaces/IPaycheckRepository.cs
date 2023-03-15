using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface IPaycheckRepository:IRepository<Paycheck>
    {
        Task UpdateSalary(Paycheck paycheck);
    }
}
