using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class EventoModel
    {
        public int EventoId { get; set; }
       
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string TemaEvento { get; set; }
        public  int QedPessoas { get; set; }
        public string Lote{ get; set; }
        public string ImagemUrl { get; set; }
    }
}