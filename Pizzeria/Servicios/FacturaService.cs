using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios
{
    class FacturaService
    {
        public static IEnumerable<Factura> Get()
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.Factura.ToList();
            }
        }

        public static Factura Get(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.Factura.Find(id);
            }
        }

        public static void Save(Factura factura)
        {
            using(var db = new PizzeriaDbContext())
            {
                try
                {
                    if(factura.Id != 0)
                    {
                        db.Entry(factura).State = EntityState.Modified;
                    } else
                    {
                        db.Factura.Add(factura);
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
                Factura factura = db.Factura.Find(id);
                if(factura != null)
                {
                    db.Entry(factura).State = EntityState.Deleted;
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
