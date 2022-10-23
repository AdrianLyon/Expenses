using AutoMapper;
using gastos.api.Data;
using gastos.api.Dto.Expense;
using gastos.helpers.Models;
using Microsoft.EntityFrameworkCore;

namespace gastos.api.Services.Expense
{
    public interface ICategoryService{
        Task<ICollection<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetAsync(int id);
        Task CreateAsync(CategoryCreateDto category);
        Task UpdateAsync(int id, CategoryDto category);
        Task DeleteAsync(int id);
    }
    public class CategoryService : ICategoryService
    {
        private readonly DatabaseContext _db;
        private readonly IMapper _mapper;
        public CategoryService(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper =  mapper;
        }
        public async Task CreateAsync(CategoryCreateDto category)
        {
            var entity = _mapper.Map<Category>(category);

            _db.Categories.Add(entity);

            await _db.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var deleteQuery = await _db.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();

            deleteQuery.Delete = true;
            deleteQuery.DeleteDate = DateTime.Now;
            await _db.SaveChangesAsync();
        }
        public async Task<ICollection<CategoryDto>> GetAllAsync()
        {
            var baseQuery = await _db.Categories
                                     .AsNoTracking()
                                     .Where(x => x.Delete == null)
                                     .ToListAsync();
            var entities = _mapper.Map<ICollection<Category>, ICollection<CategoryDto>>(baseQuery);
            return entities;
        }
        public async Task<CategoryDto> GetAsync(int id)
        {
            var baseQuery = await _db.Categories
                                    .AsNoTracking()
                                    .Where(x => x.Id == id &&
                                                x.Delete == null)
                                    .FirstOrDefaultAsync();

            var entity = _mapper.Map<Category, CategoryDto>(baseQuery);

            return entity;
        }
        public async Task UpdateAsync(int id, CategoryDto category)
        {
            var updateQuery = await _db.Categories
                                .Where(x => x.Id == id && x.Delete == null)
                                .FirstOrDefaultAsync();
            if(updateQuery?.Id == category.Id){
                updateQuery.Description = category.Description;
                _mapper.Map<Category>(updateQuery);
                await _db.SaveChangesAsync();
            }
        }
    }
}