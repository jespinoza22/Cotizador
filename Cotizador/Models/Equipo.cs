using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cotizador.Models
{
    public class Equipo
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string UrlFoto { get; set; }
        public string Perfil { get; set; }
        public string Nivel { get; set; }
        public string Descripcion { get; set; }
        public string UrlLinkedin { get; set; }
    }
}
