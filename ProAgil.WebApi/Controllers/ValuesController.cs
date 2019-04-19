using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento(){
                            EventoId= 1,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    },
                new Evento(){
                            EventoId= 2,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    },
                new Evento(){
                            EventoId= 3,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
         var envio = new Evento[] {
                new Evento(){
                            EventoId= 1,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    },
                new Evento(){
                            EventoId= 2,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    },
                new Evento(){
                            EventoId= 3,
                            Tema="Angular e .net Core",
                            Local="São Paulo",
                            Lote="1º Lote",
                            QtdPessoas=2000,
                            DataEvento= DateTime.Now.AddDays(2).ToShortDateString()
                    }
            };

            return envio.Where(x=>x.EventoId== id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}