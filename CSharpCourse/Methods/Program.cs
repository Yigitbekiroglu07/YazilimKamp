using System;
namespace Methods;

class Program
{
    static void Main(String[] args)
    {
        Add();
        var result = Add2(30, 20); 
        Console.WriteLine(result); // Konsola yazdırmazsak sonucu göremeyiz. Bunun diğerinden farkı burada bir şey döndürdük o yüzden ekrana yazdırmamız lazım.
        // Console.ReadLine();
        Console.WriteLine(Add3(1,2,3,4,5,6));    
    }
    static void Add()
    {
        Console.WriteLine("Added!");
    }
    static int Add2(int number1, int number2)
    {
        var result = number1 + number2; 
        return result;  
    }
    static int Add3(params int[] numbers)
    {
        return numbers.Sum(); // Hazır methodlardan biri.
    }
}
