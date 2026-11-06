// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Actividad en Clase Semana 7 - Validación con do-while, tabla de multiplicar con while y acumulador.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== TABLA DE MULTIPLICAR CON CICLOS ===");
        
        int numero;
        
        // 1. Pide un número entre 1 y 12 y valídalo con do-while
        do
        {
            Console.Write("Ingrese un número entero entre 1 y 12: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out numero) && numero >= 1 && numero <= 12)
            {
                break; // Entrada válida, salimos del ciclo de validación
            }
            
            Console.WriteLine("Error: Valor inválido o fuera de rango. Debe estar entre 1 y 12.");
        } while (true);

        Console.WriteLine($"\n--- TABLA DEL {numero} (1 al 12) ---");
        
        // 2. Muestra su tabla de multiplicar del 1 al 12 con while y un contador
        int contador = 1;
        int sumaAcumulada = 0;

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            
            // 3. Acumulador de todos los resultados
            sumaAcumulada += resultado;
            contador++;
        }

        // Mostrar la suma total
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Suma total de todos los resultados: {sumaAcumulada}");
        Console.WriteLine("========================================");
    }
}