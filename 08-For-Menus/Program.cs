// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Actividad en Clase Semana 8 - Ciclos anidados (tablas 1 al 10), triángulo de asteriscos y menú con do-while y switch.

using System;

class Program
{
    static void Main(string[] args)
    {
        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("       MENÚ PRINCIPAL - SEMANA 8        ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Tablas de multiplicar del 1 al 10");
            Console.WriteLine("2. Dibujar triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("=== TABLAS DE MULTIPLICAR (1 al 10) ===\n");
                    
                    // 1. Ciclos anidados para mostrar las tablas del 1 al 10 en columnas alineadas ({valor,4})
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"--- Tabla del {i} ---");
                        for (int j = 1; j <= 10; j++)
                        {
                            int resultado = i * j;
                            Console.WriteLine($"{i,2} x {j,2} = {resultado,4}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("=== TRIÁNGULO DE ASTERISCOS ===");
                    Console.Write("Ingrese el número de filas (N): ");
                    
                    if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                    {
                        // 2. Dibujar un triángulo de asteriscos de N filas
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un número entero positivo válido.");
                    }
                    break;

                case "0":
                    Console.WriteLine("\nSaliendo del programa. ¡Hasta luego, José Adolfo!");
                    break;

                default:
                    Console.WriteLine("\nError: Opción no válida. Intente de nuevo.");
                    break;
            }

            if (opcion != "0")
            {
                Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }

        } while (opcion != "0");
    }
}