using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Service
{
    public class ExpensesServices : IExpensesService

    {
        private readonly FinanceAppContext _context;
        public ExpensesServices(FinanceAppContext context) 
        {
            _context = context;
        }
        public async Task Add(Expenses expenses)
        {
            _context.Expenses.Add(expenses);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expenses>> GetAll()
        {
            var expenses = await _context.Expenses.ToListAsync();
            return expenses;
        }

        public IQueryable GetChartData()
        {
            var data = _context.Expenses
                                .GroupBy(e => e.Category)
                                .Select(g => new
                                {

                                    Category = g.Key,
                                    Total = g.Sum(e => e.Amount)


                                });
            return data;
        }
    }
}
