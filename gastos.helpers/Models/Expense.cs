namespace gastos.helpers.Models
{
    public class Expense
    {
        public int Id {get; set;}
        public double Amount {get; set;}
        public DateTime? Date {get; set;}
        public string? Description {get; set;}
        public bool? Delete {get; set;}
        public DateTime? DeleteDate {get; set;}
        public int CategoryId{get; set;}
        public virtual Category? Category {get; set;}
    }
}