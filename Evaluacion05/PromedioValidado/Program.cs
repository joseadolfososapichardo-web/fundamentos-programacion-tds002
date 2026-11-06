// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 05 - Programa 3: Promedio de notas con validación, nota mayor y nota menor.

using System;

class Program
{
    static void Main(string[] args)
    {
        double sumaNotas = 0;
        int contadorNotas = 0;
        double notaMayor = double.MinValue;
        double notaMenor = double.MaxValue;
        double nota;

        Console.WriteLine("=== PROMEDIO DE NOTAS VALIDADAS ===");
        Console.WriteLine("Ingrese notas de 0 a 100. Digite -1 para terminar y ver resultados.");

        do
        {
            Console.Write("Ingrese nota (-1 para terminar): ");
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                if (nota == -1)
                {
                    break;
                }
                
                if (nota >= 0 && nota <= 100)
                {
                    sumaNotas += nota;
                    contadorNotas++;

                    if (nota > notaMayor) notaMayor = nota;
                    if (nota < notaMenor) notaMenor = nota;
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
            }
        } while (true);

        Console.WriteLine("\n========================================");
        Console.WriteLine("          RESULTADOS DE NOTAS           ");
        Console.WriteLine("========================================");
        if (contadorNotas > 0)
        {
            double promedio = sumaNotas / contadorNotas;
            Console.WriteLine($"Total de notas ingresadas : {contadorNotas}");
            Console.WriteLine($"Promedio general          : {promedio:N2}");
            Console.WriteLine($"Nota más alta             : {notaMayor:N2}");
            Console.WriteLine($"Nota más baja             : {notaMenor:N2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas válidas.");
        }
        Console.WriteLine("========================================");
    }
}