using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                 var results = await _eventoRepository.GetAllEventosAsync();
                return Ok(results);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha interna");
            }
        }
    }
}