using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{

    public class Pizza
    {
        public int id { get; set; }
        public string variedad { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        public float precioPorcion { get; set; }

        public float calcPrecio(Sizes size, Tipos tipo)
        {
            float precio;
            float bono; //$$ ++ segun tipo 

            if (tipo == Tipos.parrilla)
            {
                bono = 100.00F;
                precio = (int)size * precioPorcion + bono;
            } else if (tipo == Tipos.piedra)
            {
                bono = 170.00F;
                precio = (int)size * precioPorcion + bono;
            } 
            else 
            {
                precio = (int)size * precioPorcion;
            }

            return precio;
           
        }

        
        
        

       

        
    }
}
