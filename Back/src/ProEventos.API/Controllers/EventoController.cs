using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _eventos = new Evento[] {
            new Evento {
                EventoId = 1,
                Tema = "Angular 11 e .net 5",
                Local = "Belo Horizonte",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto.png"
            },
            new Evento {
                EventoId = 2,
                Tema = "Delphi para amadores",
                Local = "Iguatama",
                Lote = "1° Lote",
                QtdPessoas = 120,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto1.png"
            },
            new Evento {
                EventoId = 3,
                Tema = "Node.js",
                Local = "Belo Horizonte",
                Lote = "3° Lote",
                QtdPessoas = 450,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "Foto56.png"
            }
        };

        public EventoController(ILogger<EventoController> logger)
        {

        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _eventos.Where(evento => evento.EventoId == id);

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventos;
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";

        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";

        }
    }
}
