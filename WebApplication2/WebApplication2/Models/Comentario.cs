using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Comentario
    {
        public int id { get; set; }
        public int idMessagem { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime dataDoComentario { get; set; }
        public string autor { get; set; }
    }
}