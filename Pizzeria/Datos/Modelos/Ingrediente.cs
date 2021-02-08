using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class Ingrediente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Pizza> pizzas { get; set; }
    }
}
