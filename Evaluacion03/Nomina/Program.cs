// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 03 - Programa 1: Cálculo de nómina y deducciones de ley.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Porcentajes de deducción como constantes
        const double TASA_AFP = 0.0287;
        const double TASA_SFS = 0.0304;

        Console.WriteLine("=== CÁLCULO DE NÓMINA ===");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el pago por hora: ");
        double pagoHora = double.Parse(Console.ReadLine());

        // Procesos
        double salarioBruto = horasTrabajadas * pagoHora;
        double descuentoAfp = salarioBruto * TASA_AFP;
        double descuentoSfs = salarioBruto * TASA_SFS;
        double totalDescuentos = descuentoAfp + descuentoSfs;
        double salarioNeto = salarioBruto - totalDescuentos;

        // Salida formateada (Nombre en MAYÚSCULAS y montos con N2)
        Console.WriteLine("\n========================================");
        Console.WriteLine($"          NÓMINA DE: {nombre.ToUpper()}");
        Console.WriteLine("========================================");
        Console.WriteLine($"Salario Bruto     : RD$ {salarioBruto:N2}");
        Console.WriteLine($"Descuento AFP (2.87%): RD$ {descuentoAfp:N2}");
        Console.WriteLine($"Descuento SFS (3.04%): RD$ {descuentoSfs:N2}");
        Console.WriteLine($"Total Descuentos  : RD$ {totalDescuentos:N2}");
        Console.WriteLine($"Salario Neto      : RD$ {salarioNeto:N2}");
        Console.WriteLine("========================================");
    }
}