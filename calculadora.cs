"// Calculadora basica" 
using System;

class Program {
    static void Main() {
        Console.WriteLine("Bienvenido a la Calculadora Básica");
		Console.Write("Ingrese primer número: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("Ingrese segundo número: ");
		int b = int.Parse(Console.ReadLine());

		Console.WriteLine($"Resultado: {a + b}");
    }
}
