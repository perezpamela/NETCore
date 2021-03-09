using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Servicios
{
    public class PizzaService
    {


    public static IEnumerable<Pizza> Get() {

            using(var db = new PizzeriaDbContext())
            {
               return  db.Pizza.ToList();
            }
            
        }
                             
    public static Pizza Get(int id) {
            using (var db = new PizzeriaDbContext())
            {
                //return db.Pizza.Find(id);
                return db.Pizza.Include(pizza => pizza.Ingredientes).Where(pizza => pizza.Id == id).FirstOrDefault();
            }
        }

    public static IEnumerable<Pizza> Get(string nombre) { 
            using(var db = new PizzeriaDbContext())
            {
                IEnumerable<Pizza> pizzas = db.Pizza;
                if (!string.IsNullOrEmpty(nombre))
                {
                    pizzas = pizzas.Where(pizza => pizza.Variedad.Contains(nombre.ToUpper()));
                }
                return pizzas.ToList();
            }
                }

    public static void Save(Pizza pizza)
        {
            using(var db = new PizzeriaDbContext())
            {
                try
                {
                    if(pizza.Id != 0)
                    {
                        db.Entry(pizza).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Pizza.Add(pizza);
                    }

                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    if (e.ToString().Contains("Pizza_Variedad"))
                    {
                        throw new ApplicationException("Ya existe otra variedad de pizza con ese nombre.");   
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

    public static bool Delete(int id) {
        using(var db = new PizzeriaDbContext())
            {
                Pizza pizza = db.Pizza.Where(p => p.Id == id).FirstOrDefault<Pizza>();
                if (pizza != null)
                {
                    db.Entry(pizza).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }else
                {
                    return false;
                }
            }
        
        }
    }
}
