// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Programa 1 - Ficha personal con interpolación y cálculo de edad futura.

using System;

class Program
{
    static void Main(string[] args)
    {
        const int ANIO_ACTUAL = 2026;

        Console.WriteLine("=== FICHA PERSONAL ===");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Trabaja actualmente? (true/false): ");
        bool trabaja = bool.Parse(Console.ReadLine());

        int anosFaltantes = 30 - edad;
        int anioCumple30 = ANIO_ACTUAL + anosFaltantes;

        Console.WriteLine("\n----------------------------------");
        Console.WriteLine("          DATOS DE LA FICHA       ");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"| Nombre   : {nombre}");
        Console.WriteLine($"| Edad     : {edad} años");
        Console.WriteLine($"| Estatura : {estatura} m");
        Console.WriteLine($"| Trabaja  : {(trabaja ? "Sí" : "No")}");
        Console.WriteLine($"| Año en que cumplirá 30 años: {anioCumple30}");
        Console.WriteLine("----------------------------------");
    }
}