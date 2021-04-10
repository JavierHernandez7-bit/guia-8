using System;

namespace g8Ejercicio1
{

    class Program
    {
        /* //
         * 1-
         * Crear un programa que solicite el año de nacimiento de una persona y retorne la edad haciendo uso de procedimientos.
         * /*/
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Ejercicio 1 Edad de personas";
            edad();//Creando el procedimiento
            Console.ReadKey();
            
        }
        static void edad()
        {
            int edadPer;
            string nombre;
            Console.WriteLine("Por favor, coloque su nombre");
            nombre=(Console.ReadLine());
            Console.WriteLine("Introduzca su edad");
            edadPer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hola {nombre}, su edad obtenida es de: {edadPer}");
            Console.WriteLine("\n");
            Console.WriteLine("-->Saliendo del programa...."); Console.ReadKey();
        }
        
    }
}
