// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 03 - Programa 2: Facturación con cálculo de ITBIS y columnas alineadas.

using System;

class Program
{
    static void Main(string[] args)
    {
        const double ITBIS = 0.18;

        Console.WriteLine("=== SISTEMA DE FACTURACIÓN ===");
        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precioUnitario = double.Parse(Console.ReadLine());

        // Procesos
        double subtotal = cantidad * precioUnitario;
        double montoItbis = subtotal * ITBIS;
        double total = subtotal + montoItbis;

        // Salida con columnas alineadas
        Console.WriteLine("\n========================================");
        Console.WriteLine("             FACTURA DE VENTA           ");
        Console.WriteLine("========================================");
        Console.WriteLine($"{"Producto:",-18} {producto}");
        Console.WriteLine($"{"Cantidad:",-18} {cantidad}");
        Console.WriteLine($"{"Precio Unit.:",-18} RD$ {precioUnitario,10:N2}");
        Console.WriteLine($"{"Subtotal:",-18} RD$ {subtotal,10:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-18} RD$ {montoItbis,10:N2}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{"TOTAL A PAGAR:",-18} RD$ {total,10:N2}");
        Console.WriteLine("========================================");
    }
}