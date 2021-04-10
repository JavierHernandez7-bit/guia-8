using System;

namespace guia8Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed; Console.BackgroundColor = ConsoleColor.Black; Console.Clear();
            Console.Title = "Ejercicio guia 8 Parte 3";
            
            
                // Declare variables and then initialize to zero.
                int datoA = 0; int datoB = 0, datoEx = 0, altura = 0, peso = 0;

                
                Console.WriteLine("Calculadora Multiple\r");
                Console.WriteLine("------------------------\n");

            Console.WriteLine("NOTA IMPORTANTE** Si desea la opcion *m* introduzca de esta forma: Dato 1 en kilogramos  y Dato 2 en metros ");
            Console.WriteLine("A continuacion:");            
            datoA = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Por favor, digite el segundo");
            datoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escoja la opcion que usted desee realizar:");
            Console.WriteLine("\ta - Dividir");
            Console.WriteLine("\ts - Obtener cubo");
            Console.WriteLine("\tm - Indice de Masa Corporal IMC ");
            Console.WriteLine("\td - Salir");
            Console.Write("¿Cual es tu eleccion?: ");
            Console.WriteLine("Por favor, digite el primer dato");
            Calculos(datoA, datoB, datoEx,peso,altura);
            //procedimiento 
            
            static void Calculos(int datoA,int datoB, int datoEx, int peso, int altura)
            {
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"Resultado: {datoA} / {datoB} = " + (datoA + datoB));
                        break;
                    case "s":
                        datoEx = datoA + datoB;
                        Console.WriteLine($"Resultado: {datoA} elevado al cubo = " + (Math.Pow(datoA, 3)));
                        Console.WriteLine($"Resultado: {datoB} elevado al cubo = " + (Math.Pow(datoB, 3)));
                        break;

                    case "m":
                        
                        Console.WriteLine($"Resultado IMC = " + (peso / Math.Pow(altura,2)));
                        break;
                    case "d":
                        //Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        Console.Clear();
                        break;
                }
            }
                
                Console.Write("Presione cualquier tecla para salir de la aplicacion...");
                Console.ReadKey();
            
        }    
    }
}
