//Método sumar, restar, multiplicar y dividir. El resultado lo va a escribir por consola.
//en program.cs hacer un menú. Escribir en la consola: introducir una opción. Repetir las opciones hasta que el usuario pulse "salir"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  public class Principal
{
    
    public static void Main (string [] args)
    {
       
        int opcion= 0;
        
          
            Console.WriteLine("Bienvenido al menú de la calculadora.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Opción:");
            opcion = Int32.Parse(Console.ReadLine());
            
         switch (opcion)
        {
            
            case 1:                               
                Console.WriteLine("Introduzca un numero: ");
               int num1 = Int32.Parse (Console.ReadLine());
                Console.WriteLine("Introduzca otro número:");
               int num2 = Int32.Parse (Console.ReadLine());
                Console.WriteLine("El resultado de la suma es");
                Calculadora.Suma();
                break;
            
                


        }


        }


        


    }
   
    
