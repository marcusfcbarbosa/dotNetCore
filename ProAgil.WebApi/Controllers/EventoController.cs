using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Domain.Entityes;
using ProAgil.Repository.Interfaces;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController: ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;
        public EventoController(IEventoRepository eventoRepository){
                _eventoRepository = eventoRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            try
            {
                 var results = await _eventoRepository.GetAllEventosAsync(false);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha interna");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _eventoRepository.GetAllEventosAsyncById(id,false);
            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]Evento model){
            try{
                    //Depois ver o Post como ta ficando
                    if(await _eventoRepository.SaveChangesAsync())
                        return Created($"/api/evento/{model.Id}",model);

            }catch(System.Exception){
                    return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha interna");
            }
            return BadRequest();
        }
    }
}