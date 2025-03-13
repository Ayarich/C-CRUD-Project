using FinanceApp.Models;

namespace FinanceApp.Data.Service
{
    public interface IExpensesService
    
    {
        Task<IEnumerable<Expenses>> GetAll();
        Task Add(Expenses expenses);

        IQueryable GetChartData();

    }
}
