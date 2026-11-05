// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Tarea Semana 3 - Uso de estructuras de control condicionales (If-Else) para evaluar calificaciones.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- EVALUACIÓN DE CALIFICACIÓN ---");
        Console.Write("Ingrese su calificación final (0 - 100): ");
        int calificacion = int.Parse(Console.ReadLine());

        if (calificacion >= 90 && calificacion <= 100)
        {
            Console.WriteLine("Resultado: Aprobado con Sobresaliente (A). ¡Excelente trabajo!");
        }
        else if (calificacion >= 80 && calificacion < 90)
        {
            Console.WriteLine("Resultado: Aprobado con Notable (B). ¡Muy bien!");
        }
        else if (calificacion >= 70 && calificacion < 80)
        {
            Console.WriteLine("Resultado: Aprobado con Aceptable (C).");
        }
        else if (calificacion >= 60 && calificacion < 70)
        {
            Console.WriteLine("Resultado: Aprobado con Suficiente (D).");
        }
        else if (calificacion >= 0 && calificacion < 60)
        {
            Console.WriteLine("Resultado: Reprobado (F). ¡A esforzarse más la próxima vez!");
        }
        else
        {
            Console.WriteLine("Error: Calificación inválida. Debe estar entre 0 y 100.");
        }
    }
}