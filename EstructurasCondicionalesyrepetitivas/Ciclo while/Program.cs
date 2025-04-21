using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace que agrupa y organiza las clases relacionadas
// "Ciclo_while" es el nombre del espacio de nombres en este caso
namespace Ciclo_while
{
    // Clase principal del programa
    // "internal" significa que solo es visible dentro de este ensamblado/proyecto
    // "Program" es el nombre estándar para la clase principal en aplicaciones de consola
    internal class Program
    {
        // Método principal - punto de entrada de la aplicación
        // "static" indica que pertenece a la clase y no necesita una instancia
        // "void" significa que no devuelve ningún valor
        // "string[] args" permite recibir parámetros desde la línea de comandos
        static void Main(string[] args)
        {
            // Declaración e inicialización de la variable contador
            // Se inicia en 0 y controlará el número de iteraciones
            int contador = 0;

            // Estructura de control while (mientras)
            // El bloque se ejecutará mientras se cumpla la condición (contador < 3)
            // A diferencia del do-while, primero verifica la condición antes de ejecutar
            while (contador < 3)
            {
                // Imprime en consola el valor actual del contador
                // Usa interpolación de strings ($) para incluir el valor de la variable
                Console.WriteLine($"Contador: {contador}");

                // Incrementa el contador en 1 (contador = contador + 1)
                // Esto evita un bucle infinito y hace que eventualmente la condición sea falsa
                contador++;
            }

            // Pausa la ejecución hasta que el usuario presione una tecla
            // Evita que la consola se cierre inmediatamente en entornos de desarrollo
            Console.ReadKey();
        }
    }
}