// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Actividad en Clase Semana 6 - Estructuras de decisión (Calificación con validación y Calculadora con Switch).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       ACTIVIDAD EN CLASE - SEMANA 6    ");
        Console.WriteLine("========================================");
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Evaluación de Calificación (If - Else if - Else)");
        Console.WriteLine("2. Calculadora Básica (Switch)");
        Console.Write("Ingrese su opción (1 o 2): ");
        
        string opcionMenu = Console.ReadLine();

        if (opcionMenu == "1")
        {
            // --- PARTE 1: CALIFICACIÓN ---
            Console.WriteLine("\n--- EVALUACIÓN DE CALIFICACIÓN ---");
            Console.Write("Ingrese una nota entera (0 - 100): ");
            string inputNota = Console.ReadLine();

            // Validación con int.TryParse y if
            if (int.TryParse(inputNota, out int nota))
            {
                if (nota >= 0 && nota <= 100)
                {
                    if (nota >= 90)
                    {
                        Console.WriteLine($"Nota {nota}: Letra A. ¡Excelente desempeño!");
                    }
                    else if (nota >= 80)
                    {
                        Console.WriteLine($"Nota {nota}: Letra B. ¡Muy buen trabajo!");
                    }
                    else if (nota >= 70)
                    {
                        Console.WriteLine($"Nota {nota}: Letra C. Aprobado de manera aceptable.");
                    }
                    else
                    {
                        Console.WriteLine($"Nota {nota}: Letra F. Reprobado. ¡A esforzarse más!");
                    }
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada inválida. Debe ingresar un número entero.");
            }
        }
        else if (opcionMenu == "2")
        {
            // --- PARTE 2: CALCULADORA CON SWITCH ---
            Console.WriteLine("\n--- CALCULADORA BÁSICA ---");
            Console.Write("Ingrese el primer número: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Ingrese el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("\nElija la operación:");
                    Console.WriteLine("1. Sumar (+)");
                    Console.WriteLine("2. Restar (-)");
                    Console.WriteLine("3. Multiplicar (*)");
                    Console.WriteLine("4. Dividir (/)");
                    Console.Write("Opción (1-4): ");
                    
                    string operacion = Console.ReadLine();

                    switch (operacion)
                    {
                        case "1":
                            Console.WriteLine($"\nResultado: {num1} + {num2} = {num1 + num2:F2}");
                            break;
                        case "2":
                            Console.WriteLine($"\nResultado: {num1} - {num2} = {num1 - num2:F2}");
                            break;
                        case "3":
                            Console.WriteLine($"\nResultado: {num1} * {num2} = {num1 * num2:F2}");
                            break;
                        case "4":
                            if (num2 != 0)
                            {
                                Console.WriteLine($"\nResultado: {num1} / {num2} = {num1 / num2:F2}");
                            }
                            else
                            {
                                Console.WriteLine("\nError: No se puede dividir entre cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("\nError: Opción de operación no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: El segundo número no es válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer número no es válido.");
            }
        }
        else
        {
            Console.WriteLine("Opción principal no válida.");
        }
    }
}