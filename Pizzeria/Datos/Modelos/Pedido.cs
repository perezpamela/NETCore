using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public string ClienteNombre { get; set; }
        public DateTime Fecha { get; set; }
        public int Demora { get; set; }
        public EstadoPedido Estado { get; set; }
        public List<DetallePedido> DetallesPedidos { get; set; }

        //public DetallePedido DetallePedido { get; set; }
        public Factura Factura { get; set; }

    }
}
