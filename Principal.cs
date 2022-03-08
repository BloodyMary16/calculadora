using System;

public class Menu
{


    public static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int opcion = 0;
        Console.WriteLine("Introduzca un número:");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro número:");
        num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Seleccione la operación que desea realizar: ");
        Console.WriteLine("º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º-º");
        Console.WriteLine("Opción 1: Sumar");
        Console.WriteLine("Opción 2: Restar");
        Console.WriteLine("Opción 3: Multiplicar");
        Console.WriteLine("Opción 4: Dividir");
        opcion = Int32.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Calculadora.Suma(num1, num2);
                break;
            case 2:
                Calculadora.Resta(num1, num2);
                break;
            case 3:
                Calculadora.Multiplicación(num1, num2);
                break;
            case 4:
                Calculadora.Division(num1, num2);
                break;
            default:
                Console.WriteLine("Debe introducir un valor numérico válido.");
                break;
        }
    }
}


