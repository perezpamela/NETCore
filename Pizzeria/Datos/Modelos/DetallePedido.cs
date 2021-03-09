using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public Tipos Tipo { get; set; }
        public Sizes Size { get; set; }
        public float SubTotal { get; set; }

        public int PedidoId { get; set; } 
        public Pedido Pedido { get; set; }

        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        
        

        public float calcSubTotal(float precio)
        {  
            return  precio * this.Cantidad;
        }

    }
}
