using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class DetallePedido
    {
        public int id { get; set; }
        public Pedido pedido { get; set; }
        public Pizza pizza { get; set; }
        public EstadoDetalle estadoDetalle { get; set; }
        public float subTotal { get; set; }


    }
}
