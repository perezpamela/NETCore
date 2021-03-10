using System;
using static System.Console;
using Datos.Modelos;
using Servicios;
using System.Collections.Generic;

//Datos curiosos: le puse a la propiedad nombre del modelo Ingredientes Unique e igual recibe nombres duplicados. (?

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creo ingredientes 
            Ingrediente palmitos = new Ingrediente("Palmitos");
            Ingrediente queso1 = new Ingrediente("Queso Muzzarella");
            Ingrediente queso2 = new Ingrediente("Queso Roquefort");
            Ingrediente queso3 = new Ingrediente("Queso Parmesano");
            Ingrediente queso4 = new Ingrediente("Queso Fontina");
            Ingrediente aceituna1 = new Ingrediente("Aceitunas Verdes");
            Ingrediente aceituna2 = new Ingrediente("Aceitunas Negras");

            // Creo pizzas
            Pizza muzzarella = new Pizza("Muzzarella Común", 170.00F, null);
            Pizza cuatroQuesos = new Pizza("Cuatro Quesos", 200.00F, null);
            Pizza conPalmitos = new Pizza("Muzzarella con Palmitos", 280.00F, null);


            //Esto ya está en la bd -->

            /*
              

            //Los ingreso a la bd
            IngredienteService.Save(palmitos);
            IngredienteService.Save(queso1);
            IngredienteService.Save(queso2);
            IngredienteService.Save(queso3);
            IngredienteService.Save(queso4);
            IngredienteService.Save(aceituna1);
            IngredienteService.Save(aceituna2);

            

            //Las ingreso a la bd
            PizzaService.Save(muzzarella);
            PizzaService.Save(cuatroQuesos);
            PizzaService.Save(conPalmitos);

                         */
            //Modifico Pizzas
            palmitos = IngredienteService.Get(14);
            queso1 = IngredienteService.Get(15);
            queso2 = IngredienteService.Get(16);
            queso3 = IngredienteService.Get(17);
            queso4 = IngredienteService.Get(18);
            aceituna1 = IngredienteService.Get(19);
            aceituna2 = IngredienteService.Get(20);



            List<Ingrediente> listaMuzzarella = new List<Ingrediente>();
            listaMuzzarella.Add(queso1);
            listaMuzzarella.Add(aceituna1);

            List<Ingrediente> listaCuatroQuesos = new List<Ingrediente>();
            listaCuatroQuesos.Add(queso1);
            listaCuatroQuesos.Add(queso2);
            listaCuatroQuesos.Add(queso3);
            listaCuatroQuesos.Add(queso4);
            listaCuatroQuesos.Add(aceituna2);

            List<Ingrediente> listaPalmitos = new List<Ingrediente>();
            listaPalmitos.Add(queso1);
            listaPalmitos.Add(palmitos);
            listaPalmitos.Add(aceituna1);


            muzzarella.Ingredientes = listaMuzzarella;
            cuatroQuesos.Ingredientes = listaCuatroQuesos;
            conPalmitos.Ingredientes = listaPalmitos;

            muzzarella.Id = 1;
            cuatroQuesos.Id = 2;
            conPalmitos.Id = 3;

            //Ingreso Modificaciones a la bd
            PizzaService.Save(muzzarella);
            PizzaService.Save(cuatroQuesos);
            PizzaService.Save(conPalmitos);
             




            WriteLine($"Los datos de la pizza 1 son: " + PizzaService.Get(1).Variedad + PizzaService.Get(1).Precio);

            //Numeros impares de 0 a 100
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    WriteLine(i);
                }

            }

            //Pedir dos números, mostrar los números que hay entre esos números de menor a mayor.
            //Contar cuántos números hay y cuántos de esos números son pares.

            WriteLine("Ingrese el primer número.");
            int n1 = Convert.ToInt32(ReadLine());
            WriteLine("Ingrese el segundo número.");
            int n2 = Convert.ToInt32(ReadLine());
            int count = 0;
            int pares = 0;

            if (n1 > n2)
            {
                for (int i = n2; i <= n1; i++)
                {
                    count++;
                    if (i % 2 == 0)
                    {
                        pares++;
                    }
                }
            }
            else
            {
                for (int i = n1; i <= n2; i++)
                {
                    count++;
                    if (i % 2 == 0)
                    {
                        pares++;
                    }
                }
            }
            WriteLine($"Cantidad total de números en el rango ingresado: {count}. Cantidad de números pares: {pares}.");

            //Ingresar una frase de no más de 20 caracteres y mostrar cuántas vocales tiene.
            WriteLine("Ingrese una frase (max. 20 caracteres): ");
            string frase = ReadLine();
            if (frase.Length > 20)
            {
                WriteLine("La frase es demasiado larga.");
            }
            else
            {
                string vocales = "aeiou";
                int vCount = 0;
                foreach (char letra in frase)
                {
                    if (vocales.Contains(letra))
                    {
                        vCount++;
                    }
                }

                WriteLine($"La frase tiene {vCount} vocales.");
            }

        }
    }
}
