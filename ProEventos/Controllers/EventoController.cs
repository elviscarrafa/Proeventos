using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Belo Horizonte",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString()
                },
                new Evento()
                {
                EventoId = 2,
                Tema = "Angular 11 e suas Novidades",
                Local = "São Paulo",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString()
                }

            };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;

        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);

        }



    }



   


}

