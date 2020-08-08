using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cotizador.Models
{
    public class EquipoServicio
    {
        public string idMiembro { get; set; }
        public string Descripcion { get; set; }
        public decimal precioJunior { get; set; }
        public decimal precioSemiSenior { get; set; }
        public decimal precioSenior { get; set; }
        public DateTime fechaVigencia { get; set; }
    }
}
