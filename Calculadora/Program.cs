using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            float total;
            string opcion;

            Console.Title=("Calculadora de ecuaciones basicas en C#");
            Console.WriteLine("\t\t\t/////Calculadora de ecuaciones basicas en C#/////");

            Console.WriteLine("Ingrese un numero.");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero.");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escoge una opcion de la lista a continuacion:");
            Console.WriteLine("\n\tS.-Suma\n\tR.-Resta\n\tM.-Multiplicacion\n\tD.-Division");
            opcion =Console.ReadLine();
            opcion = opcion.Trim();
            opcion = opcion.ToLower();


            switch (opcion)
            {
                case "s":
                case "suma":
                    total = num1 + num2;
                    
                    Console.WriteLine($"el total de la suma de {num1}+{num2} es:{total}");
                    break;
                case "r":
                case "resta":
                    total = num1 - num2;
                    Console.WriteLine($"el total de la resta de {num1}-{num2} es:{total}");
                    break;
                case "m":
                case "multiplicacion":
                    total = num1 * num2;
                    Console.WriteLine($"el total de la multiplicacion de {num1}*{num2} es:{total}");
                    break;
                case "d":
                case "division":
                    while (num1 == 0 || num2==0)
                    {
                        Console.WriteLine("Error: Por favor ingresar datos divisores que no sean cero");
                        Console.WriteLine("Ingrese un numero.");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero.");
                        num2 = int.Parse(Console.ReadLine());
                    }
                    total = num1 / num2;
                    Console.WriteLine($"el total de la division de {num1}/{num2} es:{total}");
                    break;
                default:
                    Console.WriteLine("Error de dato ingresado");
                    break;
            }

        }
    }
}
