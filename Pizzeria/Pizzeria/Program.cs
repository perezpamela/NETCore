using System;
using static System.Console;
using Datos.Modelos;
namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p = new Pizza();
            p.variedad = "muzzarella";
            p.precioPorcion = 10.00F;
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
