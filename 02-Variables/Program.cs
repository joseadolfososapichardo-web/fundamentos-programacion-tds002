// Autor: José Adolfo Sosa Pichardo
// Fecha: 2026-11-05
// Descripción: Tarea Semana 2 - Captura de datos, uso de variables, constante e interpolación.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Definición de constante
        const int ANIO_ACTUAL = 2026;

        // Lectura de datos desde la consola
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estatura = double.Parse(Console.ReadLine());

        // Cálculo del año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Salida con interpolación de strings
        Console.WriteLine("\n--- DATOS DE USUARIO ---");
        Console.WriteLine($"Hola {nombre}, tienes {edad} años, mides {estatura}m y naciste aproximadamente en el año {anioNacimiento}.");
    }
}