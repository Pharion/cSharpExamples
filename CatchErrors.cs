using System;
using System.Linq;

class Program
{
     static void Main()
    {
        try{
            int denom = int .Parse(Console.ReadLine());
            double result = 10/denom;

            Console.WriteLine("trying this!");
        }
        catch(FormatException)
        {
            Console.WriteLine("A format exception occurred!");
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Big bada boom");
        }

        Console.WriteLine("Program Finished");
        Console.ReadKey();
    }
}
