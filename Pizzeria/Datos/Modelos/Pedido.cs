using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Pedido
    {
        public int id { get; set; }
        public string clienteNombre { get; set; }
        public DateTime fechaPedido { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int demoraAprox { get; set; }
        public float montoTotal { get; set; }
        public EstadoPedido estado { get; set; }


    }
}
