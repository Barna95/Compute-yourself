using ComputeYourself.Data.Services.Base;
using Microsoft.AspNetCore.Mvc;


namespace ComputeYourself.Controllers
{
    [ApiController]
    [Route("product/[controller]")]
    public abstract class CrudControllerBase<T, Service> : ControllerBase where T : class, IEntityBase, new() where Service : IBaseService<T>
    {
        protected readonly Service _service;

        public CrudControllerBase(Service service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var entities = await _service.GetAllAsync();

            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var entity = await _service.GetByIdAsync(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(T entity)
        {
            if (entity is null)
            {
                return NotFound();
            }

            var newProduct = await _service.AddAsync(entity);
            if (newProduct is null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public virtual async Task<IActionResult> UpdateProduct(int id, T entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _service.UpdateAsync(id, entity);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _service.DeleteAsync(id);
            return Ok($"{id} got deleted!");
        }

        //private Task<bool> EntityExists(long id)
        //{
        //    return _context.Set<T>().AnyAsync(e => e.Id == id);
        //}
    }
}
