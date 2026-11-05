// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Programa 3 - Demostración de casting explícito (double a int) e implícito (int a double).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DEMOSTRACIÓN DE CASTING ===");
        Console.Write("Ingrese un número con decimales (ej. 15.89): ");
        double numeroDecimal = double.Parse(Console.ReadLine());

        // Casting explícito: convierte double a int eliminando la parte decimal
        int parteEntera = (int)numeroDecimal;

        Console.WriteLine("\n--- CASTING EXPLÍCITO ---");
        Console.WriteLine($"Número original (double) : {numeroDecimal}");
        Console.WriteLine($"Parte entera extraída (int): {parteEntera}");

        // Casting implícito: conversión automática de int a double
        int enteroBase = 25;
        double enteroConvertido = enteroBase;

        Console.WriteLine("\n--- CASTING IMPLÍCITO ---");
        Console.WriteLine($"Entero original (int)      : {enteroBase}");
        Console.WriteLine($"Convertido a double (double): {enteroConvertido}");
    }
}