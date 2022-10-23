using System.Net;
using gastos.api.Dto.Expense;
using gastos.api.Services.Expense;
using Microsoft.AspNetCore.Mvc;

namespace gastos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll (){
            var model = await _service.GetAllAsync();
            if (model == null) NotFound();
            return Ok(model);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get (int id){
            var model = await _service.GetAsync(id);
            if (model == null) NotFound();
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> Post (CategoryCreateDto category){
            await _service.CreateAsync(category);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, CategoryDto category){
            await _service.UpdateAsync(id, category);
            return StatusCode((int)HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id){
            await _service.DeleteAsync(id);
            return StatusCode((int)HttpStatusCode.NoContent);
        }
    }
}