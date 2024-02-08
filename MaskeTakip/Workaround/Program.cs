using Business.Concrete;
using Entities.Concrete;
using System;
using static Workaround.Program;

namespace Workaround;

class Program

{

    static void Main(String[] args)
    {
        // Vatandas vatandas1 = new Vatandas(); // Instance >> Vatandaş oluşturma

        SelamVer(isim:"Yiğit");
        SelamVer(isim: "Ahmet");
        SelamVer(); 

        Person person1 = new Person ();  
        person1.FirstName = "Engin";

        Person person2 = new Person();
        person2.FirstName = "Murat";

        int sonuc = Topla(3,5);

        PttManager pttManager = new PttManager(new ForeignManager());

        pttManager.GiveMask(person1);

    }
    // Method
    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine(" Merhaba " +isim);


    }

    static int Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam " + sonuc);    
        return sonuc;
    }



}   
