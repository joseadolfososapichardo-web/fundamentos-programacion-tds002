// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Programa 2 - Conversión de pesos dominicanos a dólares usando constante.

using System;

class Program
{
    static void Main(string[] args)
    {
        const double TASA_USD = 60.25;

        Console.WriteLine("=== CONVERSOR DE MONEDA ===");
        Console.Write("Ingrese el monto en pesos (DOP): ");
        double montoPesos = double.Parse(Console.ReadLine());

        double montoDolares = montoPesos / TASA_USD;

        Console.WriteLine("\n--- RESULTADO DE CONVERSIÓN ---");
        Console.WriteLine($"Monto en DOP : RD$ {montoPesos:N2}");
        Console.WriteLine($"Tasa del día : 1 USD = RD$ {TASA_USD:N2}");
        Console.WriteLine($"Monto en USD : US$ {montoDolares:N2}");
    }
}