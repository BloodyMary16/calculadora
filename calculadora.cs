
    public static class Calculadora
    { 
       
        public static int Suma()
        {
            int num1= 0;
            int num2=0;
            int result=0;
            Console.WriteLine("Introduzca un numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero para proceder con la SUMA: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + "+ " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicacion, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            
        return result;
        }
        public static int Resta()
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
        return result;

    }
    public static int Multiplicacion()
    {
        int num1;
        int num2;
        int result;
        Console.WriteLine("Introduzca un numero: ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro numero para proceder con la MULTIPLICACION: ");
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 * num2;
        Console.WriteLine("El resultado de " + num1 + "x " + num2 + "es: " + result);
        Console.WriteLine("");
        Console.WriteLine("Muchas gracias por utilizar nuestra aplicacion, \nesperamos volverte a ver muy pronto.");
        Console.ReadLine();
        Environment.Exit(0);
        return result;
    }
    public static int Division()
    {
        int num1;
        int num2;
        int result;
        Console.WriteLine("Introduzca un numero: ");
        num1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca otro numero para proceder con la DIVISION: ");
        num2 = Int32.Parse(Console.ReadLine());
        result = num1 / num2;
        Console.WriteLine("El resultado de " + num1 + "+ " + num2 + "es: " + result);
        Console.WriteLine("");
        Console.WriteLine("Muchas gracias por utilizar nuestra aplicacion, \nesperamos volverte a ver muy pronto.");
        Console.ReadLine();
        Environment.Exit(0);
        return result;

    }




    }
}

