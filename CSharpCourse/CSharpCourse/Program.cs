using System;
namespace TypesandVariables;


class Program
{
    static void Main(String[] args)
    {
        var number7 = 10;
        number7 = 'A'; // A yerine 65 yazdırdı. Çünkü var değiken tutar. Burada da int tutuyor.
        decimal number6 = 10; // Virgülden sonra 28-29 tane sayı tutar. Double'dan daha büyük.
        double number5 = 10.4; // Ondalıklı sayıları tutar. Bellekte 64 bitlik veri tutar.
        int number1 = 10; // 32 bit yer kaplar
        long number2 = 21447483647; // 64 bit yer kaplar
        short number3 = 32767;
        byte number4 = 255; // 0-255 arası 
        bool condition = false; // Değer tipidir. True ya da false tutar.
        char character = 'a'; // Karakter tutar. Yazdırıldığı zaman klavyedeki karakterin ASCII karşılığını verir.
        Console.WriteLine("number1 is {0}",number1);
        Console.WriteLine("number2 is {0}", number2);
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Friday);// Enum >> Diziye benzer. Yararı string gibi tek tek yazmamamızı sağlar.
        Console.WriteLine("number7 is {0}", number7);
    }

}
enum Days
{
    Monday, Sunday, Tuesday, Thirsday, Friday, Wednesday,  
}