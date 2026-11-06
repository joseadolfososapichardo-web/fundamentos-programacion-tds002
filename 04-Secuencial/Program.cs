// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Actividad en Clase Semana 4 - Programas secuenciales (Conversor de unidades: Libras a Kg y Fahrenheit a Celsius).

using System;

class Program
{
    static void Main(string[] args)
    {
        // Constante de conversión de libras a kilogramos
        const double LIBRAS_A_KG = 0.453592;

        Console.WriteLine("=== CONVERSOR DE UNIDADES (SEMANA 4) ===");

        // 1. Conversión de Peso (Libras a Kilogramos)
        Console.Write("\nIngrese el peso en libras (lb): ");
        double pesoLibras = double.Parse(Console.ReadLine());

        double pesoKilogramos = pesoLibras * LIBRAS_A_KG;

        // 2. Conversión de Temperatura (Fahrenheit a Celsius)
        Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
        double tempFahrenheit = double.Parse(Console.ReadLine());

        double tempCelsius = (tempFahrenheit - 32) * 5.0 / 9.0;

        // Mostrar resultados formateados a 2 decimales ({valor:F2})
        Console.WriteLine("\n========================================");
        Console.WriteLine("          RESULTADOS DE CONVERSIÓN      ");
        Console.WriteLine("========================================");
        Console.WriteLine($"| Peso ingresado     : {pesoLibras:F2} lb");
        Console.WriteLine($"| Equivalente en kg  : {pesoKilogramos:F2} kg");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"| Temperatura en °F  : {tempFahrenheit:F2} °F");
        Console.WriteLine($"| Equivalente en °C  : {tempCelsius:F2} °C");
        Console.WriteLine("========================================");
    }
}