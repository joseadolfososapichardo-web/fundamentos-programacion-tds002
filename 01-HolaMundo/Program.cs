// Autor: José Adolfo Sosa Pichardo
// Fecha: 2026-11-05
// Descripción: Tarjeta de presentación personal.

using System;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "José Adolfo Sosa Pichardo";
        string matricula = "2026-0743";
        string carrera = "Tecnólogo en Ciberseguridad";
        string frase = "La seguridad no es un producto, es un proceso.";

        Console.WriteLine("**************************************************");
        Console.WriteLine("=                  TARJETA DE PRESENTACIÓN       =");
        Console.WriteLine("**************************************************");
        Console.WriteLine($"| Nombre   : {nombre,-35} |");
        Console.WriteLine($"| Matrícula: {matricula,-35} |");
        Console.WriteLine($"| Carrera  : {carrera,-35} |");
        Console.WriteLine($"| Frase    : {frase,-35} |");
        Console.WriteLine("**************************************************");
    }
}