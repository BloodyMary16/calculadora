using System;
using utilidadescalculadora;
namespace CalculadoraSuprema{

    public class Menu
{
    public static void Main(string[] args)
    {
        Calculadora calculadora = new ();
        decimal num1 = 0;
        decimal num2 = 0;
        decimal opcion = 0;
        Console.WriteLine("Seleccione la operación que desea realizar: ");
        Console.WriteLine("º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º");
        Console.WriteLine("Opción 1: Sumar");
        Console.WriteLine("Opción 2: Restar");
        Console.WriteLine("Opción 3: Multiplicar");
        Console.WriteLine("Opción 4: Dividir");
        opcion = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca un número:");
        num1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro número:");
        num2 = decimal.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (opcion)
        {
            case 1:
                
                calculadora.Suma(num1, num2);
                break;
            case 2:
                calculadora.Resta(num1, num2);
                break;
            case 3:
                calculadora.Multiplicacion(num1, num2);
                break;
            case 4:
                calculadora.Division(num1, num2);
                break;
            default:
                Console.WriteLine("Debe introducir un valor numérico válido.");
                break;
        }
    }
}




}
