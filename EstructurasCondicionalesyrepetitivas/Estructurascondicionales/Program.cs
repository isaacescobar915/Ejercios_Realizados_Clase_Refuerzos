using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructurascondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 15;  // Variable que almacena la edad a evaluar

            // Estructura condicional if-else
            if (edad >= 18)  // Condición para verificar mayoría de edad
                Console.WriteLine("Es adulto");  // Se ejecuta si la condición es verdadera
            else
                Console.WriteLine("Es menor");  // Se ejecuta si la condición es falsa

            Console.ReadKey();  // Mantiene abierta la consola
        }
    }
}
