using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculadora
{

    public decimal Suma(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 + num2;
        Console.Write("\nEl resultado es: " + result);
        return result;
    }
    public decimal Resta(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 - num2;
        Console.WriteLine("\nEl resultado es: " + result);
        return result;
    }
    public decimal Multiplicacion(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 * num2;
        Console.WriteLine("\nEl resultado es: " + result);
        return result;
    }
    public decimal Division(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 / num2;
        Console.WriteLine("\nEl resultado es: " + result);
        return result;
    }
}

