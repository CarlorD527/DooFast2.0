using Core.Entities;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DooFast2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IGenericRepository<Usuario> _genericRepository;

        public UsuarioController(IGenericRepository<Usuario> genericRepository)
        {
            _genericRepository = genericRepository;
        }


        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {

            var spec = new UsuarioWithRolAndRestaurante();
            var usuarios = await _genericRepository.GetAllWithSpec(spec);

            return Ok(usuarios);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            //spec = debe incluir la logica de la consulta y tambien debe incluir las relaciones entre las entidades.
            var spec = new UsuarioWithRolAndRestaurante(id);
            return await _genericRepository.GetByIdWithSpec(spec);
        }

        //// POST api/<UsuarioController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
