using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1;  // Variable de control para el switch

            // Estructura switch para evaluar múltiples casos
            switch (opcion)
            {
                case 1:  // Si opcion == 1
                    Console.WriteLine("Opción 1");
                    break;  // Sale del switch

                case 2:  // Si opcion == 2
                    Console.WriteLine("Opción 2");
                    break;

                default:  // Si no coincide con ningún caso
                    Console.WriteLine("Otra opción");
                    break;
            }

            Console.ReadKey();  // Pausa antes de cerrar
        }
    }
}