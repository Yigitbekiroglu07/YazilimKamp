using System;
namespace Conditionals;

class Program
{
    static void Main(String[] args)
    {
        var number = 11;
        // Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); // True ya da false'ı aynı kodda yazmak. Single Line If.
        // Console.ReadLine();

        switch (number)
        {
            case 10:
                Console.WriteLine("Number is 10");
                break;

            case 11:
                Console.WriteLine("Number is 11");
                break;

            default: // else'e denk gelir.
                Console.WriteLine("Number is not 10 or 11");
                break;
        }
    }
}
