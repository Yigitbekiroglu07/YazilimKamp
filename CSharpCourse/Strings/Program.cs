using System;
namespace Strings;

class Program
{
    static void Main(String[] args)
    {
        string sentence = "My name is Yiğit Bekiroğlu ";

        var result = sentence.Length; // dizinin kaç karakterden oluştuğunu verir.
        Console.WriteLine(result); 
        var result2 = sentence.Clone(); // Klon oluşturur.
        Console.WriteLine(result2); 
        bool result3 = sentence.EndsWith("u");  
        bool result4 = sentence.StartsWith("My name");
        var result5 = sentence.IndexOf("name"); // Bir stringe belli karakteri aramak için kullanılır.
        var result6 = sentence.IndexOf(""); // Gördüğü ilk boşluğu konsola yazar.
        var result7 = sentence.LastIndexOf("");
        Console.WriteLine(result7);
        var result8 = sentence.Insert(0, "Hello, "); //Bir stringe ekleme yapmak için. 0. karakterden itibaren hello diye bir şey ekle.
        var result9 = sentence.Substring(3); // 3. karakterden itibaren yazdır.
        Console.WriteLine(result9);
        var result10 = sentence.ToLower(); // tüm metni küçük yazdırır.
        var result11 = sentence.ToUpper(); // tüm metni büyük yazdırır.
        var result12 = sentence.Replace("","-"); // Bir metin içinde belli karakterleri değiştirmek için kullanılır. Tüm boşluklar yerine çizgi kullanılır.
        var result13 = sentence.Remove(2); // 2'den itibaren yok et.
        Console.WriteLine(result13);
        /*string city = "Ankara";
        foreach (var item in city)
        {
            Console.WriteLine(item);    
        }

        string city2 = "İstanbul";
        string result = city + city2;
        Console.WriteLine(result);  
        Console.WriteLine(string.Format("{0} {1}",city,city2));   */
    }
}
