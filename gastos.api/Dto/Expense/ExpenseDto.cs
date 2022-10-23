namespace gastos.api.Dto.Expense
{
    public class ExpenseDto
    {
        public int Id {get; set;}
        public double Amount {get; set;}
        public DateTime? Date {get; set;}
        public string? Description {get; set;}
        public int CategoryId{get; set;}
        public CategoryDto? Category {get; set;}
    }
}