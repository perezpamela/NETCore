using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Ingrediente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
