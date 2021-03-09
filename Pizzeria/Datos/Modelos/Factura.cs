using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public formaDePago FormaDePago { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        
    }
}
