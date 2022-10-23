using AutoMapper;
using gastos.api.Dto.Expense;
using gastos.helpers.Models;

namespace gastos.api.Mappings
{
    public class ExpenseProfile : Profile
    {
        public ExpenseProfile()
        {
            CreateMap<Expense, ExpenseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateDto>().ReverseMap();
        }
    }
}