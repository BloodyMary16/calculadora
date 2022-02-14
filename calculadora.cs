
namespace calculadora
{
    public class Calculadora
    { 
       
        public void Suma()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Introduzca un n�mero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro n�mero para proceder con la SUMA: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + "+ " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicaci�n, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void Resta()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Introduzca un n�mero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro n�mero para proceder con la RESTA: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + "- " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicaci�n, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            Environment.Exit(0);

        }
        public void Multiplicacion()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Introduzca un n�mero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro n�mero para proceder con la MULTIPLICACI�N: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + "x " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicaci�n, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void Division()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Introduzca un n�mero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro n�mero para proceder con la DIVISI�N: ");
            num2 = Int32.Parse(Console.ReadLine());
            result = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + "+ " + num2 + "es: " + result);
            Console.WriteLine("");
            Console.WriteLine("Muchas gracias por utilizar nuestra aplicaci�n, \nesperamos volverte a ver muy pronto.");
            Console.ReadLine();
            Environment.Exit(0);

        }




    }
}

