using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DooFast2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IGenericRepository<Rol> _rolRepository;

        public RolController(IGenericRepository<Rol> rolRepository)
        {
            _rolRepository = rolRepository;
        }

        // GET: api/<RolController>
        [HttpGet]
        public async Task<ActionResult<List<Restaurante>>> GetRestaurantes()
        {
           var roles = await _rolRepository.GetAllAsync();

           return Ok(roles);
        }
 
        // GET api/<RolController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> GetRol(int id)
        {

            return await _rolRepository.GetByIdAsync(id);
        }

        //// POST api/<RolController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<RolController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RolController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
