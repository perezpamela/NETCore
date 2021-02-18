using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Pedido
    {
        public int id { get; set; }
        public string clienteNombre { get; set; }
        public DateTime fecha { get; set; }
        public int demora { get; set; }
        public EstadoPedido estado { get; set; }


    }
}
