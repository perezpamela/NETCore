using System;
using static System.Console;
using Datos.Modelos;
using Servicios;
using System.Collections.Generic;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            Pizza p2 = new Pizza();
            p.Variedad = "Muzzarella";
            p.Precio = 50.00F;
            p2.Id = 2;
            p2.Precio = 120.00F;
            p.Variedad = "Napolitana modificada";
            PizzaService.Save(p2);

            //PizzaService.save(p);
            //PizzaService.save(p2);
            //PizzaService.delete(3);
            //PizzaService.delete(4);
            //PizzaService.delete(5);
            //PizzaService.delete(6);
            //PizzaService.delete(7);
            //PizzaService.delete(8);
            //PizzaService.delete(9);
            //PizzaService.delete(10);
            //PizzaService.delete(11);
            //PizzaService.delete(12);

            Pizza pi = PizzaService.Get(1);
            Write(pi.Variedad);
            foreach(Pizza pizza in PizzaService.Get())
            {
                Write($"La variedad de pizza es: {pizza.Variedad} y el precio es: ${pizza.Precio}.");
            }


            float precio = p.calcPrecio(Sizes.large, Tipos.piedra);

            WriteLine($"El precio a pagar es: {precio}");

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
