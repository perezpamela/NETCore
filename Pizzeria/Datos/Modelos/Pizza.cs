using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{

    public class Pizza
    {
        public int Id { get; set; }
        public string Variedad { get; set; }
        public float Precio { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }

        public DetallePedido DetallePedido { get; set; }
        

        public float calcPrecio(Sizes size, Tipos tipo)
        {
            float adicionalSize = 0.00F;
            float adicionalTipo = 0.00F;

            //Asumo como normal una pizza de molde con ocho porciones. Lo demás lleva costo adicional.

            if(size == Sizes.medium) //Si es de 10 porciones lleva un recargo del 30%
            {
                adicionalSize = 1.30F;
                Precio *= adicionalSize;
            } 
            if (size == Sizes.large) //Si es de 12 porciones lleva un recargo del 60%
            {
                adicionalSize = 1.60F;
                Precio *= adicionalSize;
            }
            if(tipo == Tipos.parrilla) //Si es a la parrilla lleva un recargo del 15%
            {
                adicionalTipo = 1.15F;
                Precio *= adicionalTipo;
            }
            if(tipo == Tipos.piedra) //Si es a la piedra lleva un recargo del 30%
            {
                adicionalTipo = 1.30F;
                Precio *= adicionalTipo;
            }

            return Precio;
           
        }
                          
    }
}
