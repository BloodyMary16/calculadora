using System;

public class Menu
{
    public static void Main(string[] args)
    {
        Console.Title = "CALCULADORA SUPREMA";
        Calculadora calculadora = new ();
        decimal num1 = 0;
        decimal num2 = 0;
        decimal opcion = 0;
        
        
        do
        {
            Console.WriteLine("\nIntroduzca un número:");
            num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número:");
            num2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione la opción que desea realizar: ");
            Console.WriteLine("☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺");
            Console.WriteLine("Opción -1: SALIR");
            Console.WriteLine("Opción 1: Sumar");
            Console.WriteLine("Opción 2: Restar");
            Console.WriteLine("Opción 3: Multiplicar");
            Console.WriteLine("Opción 4: Dividir");
            Console.WriteLine("Opción 5: Potencias");
            Console.WriteLine("Opción 6: Historial de operaciones");
            Console.WriteLine("Seleccione la operación que desea realizar:");
            
            opcion = Int32.Parse(Console.ReadLine());
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
                case -1:
                    return;
                default:
                    Console.WriteLine("Debe introducir un valor numérico válido.");
                    break;
            }
            
        }
        while (opcion != -1);

    }
}


