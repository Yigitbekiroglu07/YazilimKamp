using System;
using System.Globalization;

namespace Generics;

class Program
{
    static void Main(String[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count);
        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        sehirler2.Add("Ankara");
        Console.WriteLine(sehirler2.Count);
    }

    class MyList<T> // Generic Class
    {
        T[] _array;
        T[] _tempArray; // Önceki değerlerin tutmak için
        public MyList()
        {
             _array = new T[0]; // 0 elemanlı bir array.
        }
        public void Add(T item)
        {
            _tempArray = _array; // Önceki değerleri tutmak için
            _array = new T[_array.Length + 1]; // Eleman sayısı 1 artar.
            for (int i = 0; i < _tempArray.Length; i++) // Önceki değerlerin Heap'te yeni adrese kaydedilmesi için
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;   // array'in eleman sayısı item'e eşitlendi
        }

        public int Count
        {
            get { return _array.Length; } // Array uzunluğu döner
            
        }

    }
}
