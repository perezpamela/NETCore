using Datos.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios
{
    public class IngredienteService
    {
        public static IEnumerable<Ingrediente> Get()
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.Ingrediente.ToList();
            }
        }

        public static IEnumerable<Ingrediente> Get(string nombre)
        {
            using(var db = new PizzeriaDbContext())
            {
                IEnumerable<Ingrediente> ingredientes = db.Ingrediente;
                if (!string.IsNullOrEmpty(nombre))
                {
                    ingredientes = ingredientes.Where(ing => ing.Nombre.Contains(nombre.ToUpper()));
                }
                return ingredientes;
            }
        }

        public static Ingrediente Get(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                return db.Ingrediente.Find(id);
            }
        }

        public static void Save(Ingrediente ingrediente)
        {
            using(var db = new PizzeriaDbContext())
            {
                try
                {
                    if(ingrediente.Id != 0)
                    {
                        db.Entry(ingrediente).State = EntityState.Modified;
                    } else
                    {
                        db.Ingrediente.Add(ingrediente);
                    }

                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    if (e.ToString().Contains("Ingrediente_Nombre"))
                    {
                        throw new ApplicationException("Ya existe un ingrediente con ese nombre.");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        public static bool Delete(int id)
        {
            using(var db = new PizzeriaDbContext())
            {
                Ingrediente ingrediente = db.Ingrediente.Where(ing => ing.Id == id).FirstOrDefault<Ingrediente>();
                if(ingrediente != null)
                {
                    db.Entry(ingrediente).State = EntityState.Deleted;
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
