using BusinessLogic.Logic;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DooFast2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private readonly IGenericRepository<Restaurante> _restauranteRepository;

        public RestauranteController(IGenericRepository<Restaurante> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }


        // GET: api/<RestauranteController>
        [HttpGet]
        public async Task<ActionResult<List<Restaurante>>> GetRestaurantes()
        {
            var restaurantes = await _restauranteRepository.GetAllAsync();

            return Ok(restaurantes);
        }

        // GET api/<RestauranteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurante>> GetRestaurante(int id)
        {

            return await _restauranteRepository.GetByIdAsync(id);
        }

        //// POST api/<RestauranteController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<RestauranteController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RestauranteController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
