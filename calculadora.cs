"// Calculadora basica" 
using System;

class Program {
    static void Main() {
        Console.WriteLine("Bienvenido a la Calculadora B�sica");
		Console.Write("Ingrese primer n�mero: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("Ingrese segundo n�mero: ");
		int b = int.Parse(Console.ReadLine());

		Console.WriteLine($"Resultado: {a + b}");
    }
}
