using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios
{
    public class PedidoService
    {
        public static IEnumerable<Pedido> Get()
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.Pedido.ToList();
            }
        }

        public static IEnumerable<Pedido> Get(string nombre)
        {
            using(var db = new PizzeriaDbContext())
            {
                IEnumerable<Pedido> pedidos = db.Pedido;
                if (!String.IsNullOrEmpty(nombre))
                {
                    pedidos = pedidos.Where(p => p.ClienteNombre.Contains(nombre.ToUpper()));
                }
                return pedidos.ToList();
            }
        }

        public static Pedido Get(int id)
        {
            using (var db = new PizzeriaDbContext())
            {
                //return db.Pedido.Find(id)
                return db.Pedido.Include(p => p.DetallesPedidos).Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public static void Save(Pedido pedido)
        {
            using (var db = new PizzeriaDbContext())
            {
                try
                {
                    if(pedido.Id != 0)
                    {
                        db.Entry(pedido).State = EntityState.Modified;
                    } else
                    {
                        db.Pedido.Add(pedido);
                    }

                    db.SaveChanges();
                    
                } catch(Exception e)
                {
                    throw new Exception("No se pudieron guardar los cambios", e);
                }
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                Pedido pedido = db.Pedido.Where(p => p.Id == id).FirstOrDefault();
                if(pedido != null)
                {
                    db.Entry(pedido).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                } else
                {
                    return false;
                }
            }
        }
    }
}
