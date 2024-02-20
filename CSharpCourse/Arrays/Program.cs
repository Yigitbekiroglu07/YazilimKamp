using System;
namespace Arrays;

class Program
{
    static void Main(String[] args)
    {
        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        // Alteernatif >>> string[] students2 = { "Engin", "Derin", "Salih" };

        // Alternatif >> string[] students3 = new[] { "Engin", "Derin", "Salih" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        string[,] regions = new string[5, 3]
        {

            {"İstanbul","İzmit","Balıkesir" },
            {"Ankara","Konya","Çorum" },
            {"Antalya","Burdur","Isparta" },
            {"Manisa","İzmir","Aydın" },
            {"Diyarbakır","Batman","Hakkari"},
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++) // İlgili dimensionu yakalamak için kullanılır. // satır 0-1-2-3-4
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++) // sütun 0-1-2
            {
                Console.WriteLine(regions[i,j]);
            }
        }
        

        

    }
}
