// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 03 - Programa 3: Cálculos geométricos (Círculo y Triángulo Rectángulo).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CÁLCULOS GEOMÉTRICOS ===");
        
        // 1. Círculo
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;

        // 2. Triángulo Rectángulo
        Console.Write("Ingrese el valor del cateto A: ");
        double catetoA = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor del cateto B: ");
        double catetoB = double.Parse(Console.ReadLine());

        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // Resultados con 2 decimales
        Console.WriteLine("\n========================================");
        Console.WriteLine("          RESULTADOS GEOMÉTRICOS        ");
        Console.WriteLine("========================================");
        Console.WriteLine("--- Círculo ---");
        Console.WriteLine($"Área            : {areaCirculo:F2}");
        Console.WriteLine($"Circunferencia  : {circunferencia:F2}");
        Console.WriteLine("\n--- Triángulo Rectángulo ---");
        Console.WriteLine($"Cateto A        : {catetoA:F2}");
        Console.WriteLine($"Cateto B        : {catetoB:F2}");
        Console.WriteLine($"Hipotenusa      : {hipotenusa:F2}");
        Console.WriteLine("========================================");
    }
}