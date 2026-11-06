// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Evaluación 05 - Programa 2: Juego de adivinar un número secreto con contador de intentos.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Genera un número secreto aleatorio entre 1 y 100
        int numeroSecreto = Random.Shared.Next(1, 101);
        int intentos = 0;
        int numeroUsuario;

        Console.WriteLine("=== ADIVINA EL NÚMERO SECRETO ===");
        Console.WriteLine("He pensado en un número entre 1 y 100. ¡Intenta adivinarlo!");

        do
        {
            Console.Write("Ingrese su suposición: ");
            if (int.TryParse(Console.ReadLine(), out numeroUsuario))
            {
                intentos++;
                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es MAYOR.");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es MENOR.");
                }
                else
                {
                    Console.WriteLine($"\n ¡Felicitaciones! Has adivinado el número en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
            }
        } while (numeroUsuario != numeroSecreto);
    }
}