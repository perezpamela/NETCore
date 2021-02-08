using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Factura
    {
        public int id { get; set; }
        public Pedido pedido { get; set; }
        public string formaDePago { get; set; }
    }
}
