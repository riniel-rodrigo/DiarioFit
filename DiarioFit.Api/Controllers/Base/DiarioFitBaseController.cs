using DiarioFit.Intf.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DiarioFit.Api.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiarioFitBaseController<TEntity, TService> : ControllerBase
        where TEntity : class
        where TService : ICRUDServer<TEntity>
    {
        private readonly TService _service;

        public DiarioFitBaseController(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            var entities = await _service.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetById(int id)
        {
            var entity = await _service.GetAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TEntity entity)
        {
            await _service.UpdateAsync(id, entity);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Create(TEntity entity)
        {
            await _service.CreateAsync(entity);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _service.DeleteAsync(id);

            if (!success)
            {
                return NotFound($"Entidade com ID {id} não encontrada.");
            }

            return NoContent();
        }

    }
}
