// Autor: José Adolfo Sosa Pichardo
// Matrícula: 2026-0743
// Descripción: Actividad en Clase Semana 3 - Operadores aritméticos, enteros y prueba de escritorio.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== OPERACIONES CON DOS NÚMEROS ENTEROS ===");
        
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine());

        // Operaciones aritméticas
        int suma = num1 + num2;
        int resta = num1 - num2;
        int producto = num1 * num2;
        
        // División real (con decimales haciendo casting a double)
        double divisionReal = (num2 != 0) ? (double)num1 / num2 : 0;
        
        // División entera y residuo (módulo)
        int divisionEntera = (num2 != 0) ? num1 / num2 : 0;
        int residuo = (num2 != 0) ? num1 % num2 : 0;

        // Verificación si el primer número es par
        bool esPar = (num1 % 2 == 0);

        // Mostrar resultados en pantalla
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Suma ({num1} + {num2}) = {suma}");
        Console.WriteLine($"Resta ({num1} - {num2}) = {resta}");
        Console.WriteLine($"Producto ({num1} * {num2}) = {producto}");
        
        if (num2 != 0)
        {
            Console.WriteLine($"División real ({num1} / {num2}) = {divisionReal:N2}");
            Console.WriteLine($"División entera ({num1} / {num2}) = {divisionEntera}");
            Console.WriteLine($"Residuo / Módulo ({num1} % {num2}) = {residuo}");
        }
        else
        {
            Console.WriteLine("Aviso: No se puede dividir ni calcular residuo entre cero.");
        }

        Console.WriteLine($"¿El primer número ({num1}) es par? -> {esPar}");
    }
}

/*
 ==============================================================================
 PRUEBA DE ESCRITORIO (Valores de la diapositiva: x = 10, y = 3)
 ==============================================================================
 Variables iniciales:
   - num1 (x) = 10
   - num2 (y) = 3

 Ejecución paso a paso:
   1. suma = 10 + 3            => 13
   2. resta = 10 - 3           => 7
   3. producto = 10 * 3        => 30
   4. divisionReal = 10.0 / 3  => 3.3333...
   5. divisionEntera = 10 / 3  => 3
   6. residuo = 10 % 3         => 1 (porque 3 * 3 = 9, para llegar a 10 falta 1)
   7. esPar = (10 % 2 == 0)    => 0 == 0 => true

 Salida esperada en consola para x = 10 e y = 3:
   - Suma = 13
   - Resta = 7
   - Producto = 30
   - División real = 3.33
   - División entera = 3
   - Residuo = 1
   - ¿Es par? = True
 ==============================================================================
*/