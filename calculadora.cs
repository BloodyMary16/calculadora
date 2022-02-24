
    public class Calculadora
    { 
       
        public static void Suma()
        {
            int num1= 0;
            int num2=0;
            int result;
           
            result = num1 + num2;
           
            
        
        }
        public static void Resta()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Introduzca un numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero para proceder con la RESTA: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + "- " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicacion, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            Environment.Exit(0);
        

    }
    public static void Multiplicacion()
    {
        int num1;
        int num2;
        int result;
        Console.WriteLine("Introduzca un numero: ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro numero para proceder con la MULTIPLICACION: ");
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 * num2;
  
        
        
    }
    public static void Division()
    {
        int num1;
        int num2;
        int result;
       
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro numero para proceder con la DIVISION: ");
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 / num2;
        Console.WriteLine("El resultado de " + num1 + "+ " + num2 + "es: " + result);
        Console.WriteLine("");
        Console.WriteLine("Muchas gracias por utilizar nuestra aplicacion, \nesperamos volverte a ver muy pronto.");
        Console.ReadLine();
        Environment.Exit(0);
        

    }

    



    }


