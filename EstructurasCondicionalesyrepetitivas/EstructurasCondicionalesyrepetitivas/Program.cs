using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasCondicionalesyrepetitivas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversión implícita (casting) de double a int - trunca los decimales
            double valorDouble = 12.78;
            int valorEntero = (int)valorDouble;  // Resultado: 12

            // Conversión explícita de string a int usando Convert.ToInt32()
            string numeroTexto = "50";
            int numeroEntero = Convert.ToInt32(numeroTexto);  // Resultado: 50

            // Mostrar resultados
            Console.WriteLine($"Valor entero (casting): {valorEntero}");
            Console.WriteLine($"Número convertido: {numeroEntero}");

            Console.ReadKey();  // Pausa antes de cerrar
        }
    }
}