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
       
       public IEnumerable<EventoModel> _eveto = new EventoModel[]{
            new EventoModel(){
                 EventoId = 1,
                    TemaEvento = "Angular 11 e .Net 5",
                    Local = "Brasilia",
                    Lote = "1 lote",
                    QedPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "Imagem.png"
            },
              new EventoModel(){
                 EventoId = 2,
                    TemaEvento = "Angular 11 e Suas novidades",
                    Local = "São Paulo",
                    Lote = "3 lote",
                    QedPessoas = 200,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemUrl = "Imagem.png"
            },
       };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<EventoModel> Get()
        {
           return  _eveto;
        }

        [HttpGet("{id}")]
        public IEnumerable<EventoModel> GetById(int id){
            return _eveto.Where(x => x.EventoId == id);
        }
    }
}
