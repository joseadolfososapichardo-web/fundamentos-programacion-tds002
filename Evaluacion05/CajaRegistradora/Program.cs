// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 05 - Programa 1: Caja registradora con do-while, subtotal, ITBIS y total.

using System;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;
        double subtotal = 0;
        int cantidadProductos = 0;
        double precio;

        Console.WriteLine("=== CAJA REGISTRADORA ===");
        Console.WriteLine("Ingrese los precios de los productos. Digite 0 para finalizar.");

        do
        {
            Console.Write("Ingrese precio (0 para salir): ");
            if (double.TryParse(Console.ReadLine(), out precio))
            {
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("El precio no puede ser negativo.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
                precio = -1; // Mantiene el ciclo activo ante errores de formato
            }
        } while (precio != 0);

        double montoItbis = subtotal * ITBIS;
        double total = subtotal + montoItbis;

        Console.WriteLine("\n========================================");
        Console.WriteLine("          FACTURA / RESUMEN             ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cantidad de productos : {cantidadProductos}");
        Console.WriteLine($"Subtotal              : RD$ {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%)           : RD$ {montoItbis:N2}");
        Console.WriteLine($"Total a Pagar         : RD$ {total:N2}");
        Console.WriteLine("========================================");
    }
}