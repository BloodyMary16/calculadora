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
        Console.Write("El resultado es: " + result);
        return result;
    }
    public void Resta(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 - num2;
        Console.WriteLine("El resultado es: " + result);
    }
    public void Multiplicacion(decimal num1, decimal num2)
    {
        decimal result;
        result = num1 * num2;
    }
   

    


 }



