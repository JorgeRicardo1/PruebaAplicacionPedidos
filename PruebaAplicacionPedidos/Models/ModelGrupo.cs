using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaAplicacionPedidos.Models
{
    internal class ModelGrupo
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public double librecnt { get; set; }
        public double librecto { get; set; }
        public double acumula { get; set; }
    }
}
