namespace gastos.api.Services.Expense
{
    public interface IExpenseService{
        Task Delete(int id);
    }
    public class ExpenseService : IExpenseService
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}