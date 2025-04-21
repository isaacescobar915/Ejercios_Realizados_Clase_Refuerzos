using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición del namespace (espacio de nombres) que agrupa lógicamente las clases.
// En este caso, el namespace es "Ciclo_do_while".
namespace Ciclo_do_while
{
    // Clase principal del programa. 
    // "internal" significa que solo es accesible dentro de este proyecto.
    // "class Program" es el nombre de la clase.
    internal class Program
    {
        // Método principal (Main), punto de entrada del programa.
        // "static" indica que el método pertenece a la clase y no a una instancia.
        // "void" significa que no retorna ningún valor.
        // "string[] args" permite recibir argumentos desde la línea de comandos.
        static void Main(string[] args)
        {
            // Declaración e inicialización de la variable "contador" en 0.
            // Esta variable controlará las iteraciones del bucle.
            int contador = 0;

            // Inicio del bucle "do-while".
            // Este bucle ejecuta el código al menos una vez y luego evalúa la condición.
            do
            {
                // Imprime en consola el valor actual del contador.
                // Se usa interpolación de cadenas ($) para incluir el valor dinámico.
                Console.WriteLine($"Contador: {contador}");

                // Incrementa el contador en 1 en cada iteración.
                contador++;

            } while (contador < 3); // Condición del bucle: seguir ejecutando mientras "contador" sea menor que 3.

            // Pausa la consola hasta que el usuario presione una tecla.
            // Útil para evitar que la ventana se cierre inmediatamente en entornos de depuración.
            Console.ReadKey();
        }
    }
}
