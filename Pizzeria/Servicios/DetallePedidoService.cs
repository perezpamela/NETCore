using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios
{
    class DetallePedidoService
    {
        public static IEnumerable<DetallePedido> Get()
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.DetallePedido.ToList();
            }
        }
        public static DetallePedido Get(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.DetallePedido.Find(id);
            }
        }

        public static void Save(DetallePedido detalle)
        {
            using(var db = new PizzeriaDbContext())
            {
                try
                {
                    if(detalle.Id != 0)
                    {
                        db.Entry(detalle).State = EntityState.Modified;
                    }
                    else
                    {
                        db.DetallePedido.Add(detalle);
                    }

                    db.SaveChanges();
                } catch (Exception e)
                {
                    throw new Exception("No se pudieron guardar los datos.", e);
                }
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                DetallePedido detalle = db.DetallePedido.Find(id);
                if(detalle != null)
                {
                    db.Entry(detalle).State = EntityState.Deleted;
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
