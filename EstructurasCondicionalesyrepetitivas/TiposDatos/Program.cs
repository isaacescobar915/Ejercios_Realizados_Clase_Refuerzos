using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Se define el espacio de nombres del proyecto
namespace TiposDatos
{
    // Clase principal del programa
    internal class Program
    {
        // Método principal, punto de entrada de la aplicación
        static void Main(string[] args)
        {
            // Declaración de una variable de tipo entero
            int entero = 10;

            // Declaración de una variable de tipo double (número con decimales)
            double flotante = 20.5;

            // Declaración de una variable de tipo booleano (verdadero o falso)
            bool booleano = true;

            // Declaración de una variable de tipo carácter (un solo carácter)
            char caracter = 'C';

            // Declaración de una variable de tipo cadena de texto
            string texto = "Ejemplo";

            // Impresión de los valores de las variables en la consola
            Console.WriteLine($"Entero: {entero}");
            Console.WriteLine($"Flotante: {flotante}");
            Console.WriteLine($"Booleano: {booleano}");
            Console.WriteLine($"Caracter: {caracter}");
            Console.WriteLine($"Texto: {texto}");

            // Espera a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
