namespace gastos.helpers.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string? Description {get; set;}
        public bool? Delete {get; set;}
        public DateTime? DeleteDate{get; set;}
    }
}