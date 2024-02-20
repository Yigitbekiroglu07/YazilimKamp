using System;
using System.Runtime.CompilerServices;

namespace IsPrimaryNumber
{
    class Program
    {
        static void Main(String[] args)
        {
            
            if (_isPrimaryNumber(7))
            {
                Console.WriteLine("This is a primary number.");
            }
            else
            {
                Console.WriteLine("This is not a primary number");
            }

        }
        private static bool _isPrimaryNumber(int number)
        {
            
            bool result = true; // Bir sayı asal mı değil mi diye değişken tutma   
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;// Örneğin 1000 sayısı 2'ye bölündüğü için diğer sayıları denemesine gerek yok. Belleğe yük olmamak için yapılan işlem.
                }
            }

            return result;
        }
    }
}

