using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //EJERCICIO PRACTICO CLASE 09

            Console.WriteLine("\n---PROGRAMA QUE DETERMINA LA CALIFICAION CORRESPONDIENTE ---\n");

            Console.WriteLine("\nIngresa tu nota: ");
            double nota=Convert.ToDouble(Console.ReadLine());

            if (nota >=7.0)
            {
                Console.WriteLine("La calificacion obtenida "+nota+" es Buena ");
                
            }
            else{

                Console.WriteLine("La calificacion obtenida "+nota+" es Deficiente ");
            }

            if (nota >=8.5)
            {
                Console.WriteLine("La calificacion obtenida "+nota+" es Muy Buena ");
                
            }
            else{

                Console.WriteLine("La calificacion obtenida "+nota+" es Deficiente ");
            }

            if (nota >=9.5)
            {
                Console.WriteLine("La calificacion obtenida "+nota+" es Excelente ");
                
            }
            else{

                Console.WriteLine("La calificacion obtenida "+nota+" es Deficiente ");
            }

            Console.ReadKey();
            
        }
    }
}