using System;
using System.Collections.Generic;
using System.Linq;
using Datos.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Servicios
{
    public class PizzaService
    {


    public static IEnumerable<Pizza> get() {

            using(var db = new PizzeriaDbContext())
            {
               return  db.Pizza;
            }
            
        }
                             
    public static Pizza get(int id) {
            using (var db = new PizzeriaDbContext())
            {
                return db.Pizza.Find(id);
            }
        }

    public static IEnumerable<Pizza> get(string nombre) { 
            using(var db = new PizzeriaDbContext())
            {
                IEnumerable<Pizza> pizzas = db.Pizza;
                if (!string.IsNullOrEmpty(nombre))
                {
                    pizzas = pizzas.Where(pizza => pizza.variedad.Contains(nombre.ToUpper()));
                }
                return pizzas;
            }
                }

    public static void save(Pizza pizza)
        {
            using(var db = new PizzeriaDbContext())
            {
                try
                {
                    if(pizza.id != 0)
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
                    if (e.ToString().Contains("Pizza_variedad"))
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

    public static bool delete(int id) {
        using(var db = new PizzeriaDbContext())
            {
                Pizza pizza = db.Pizza.Where(p => p.id == id).FirstOrDefault<Pizza>();
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
