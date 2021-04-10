using System;

namespace g8Ejercicio2
{

    class Program
    {
        static float polaresACartesianas (float radio, float angulo)
        {
            Console.WriteLine("x= " + radio * Math.Cos(angulo) + " y: " + radio * Math.Sin(angulo));
            return radio;            
        }
        static void Main(string[] args)
        {
            float radio, angulo;
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Cambios de Coordenadas";           
            Console.WriteLine("Introduzca el radio");
            radio = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el ángulo");
            angulo = float.Parse(Console.ReadLine());
            polaresACartesianas (radio, angulo);
            Console.ReadKey();
        }

    }        
}



