using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Modelos
{
    public class PizzeriaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog = Pizzeria; Integrated Security = True");
            
        }

        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Ingrediente> Ingrediente { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }


    }
}

