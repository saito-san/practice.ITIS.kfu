using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Летучка_12._12._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Publication> a = new List<Publication>();
            for (int i = 0; i < 10; i++)
            {
                DateTime b = new DateTime(2016, 12, 12);
                DateTime c = new DateTime(2016, 12, 22);

                a.Add(new Ad($"Пропала собака{i}", "глаза черные, уши длинные, хвост пистолетом", b, c));
                a.Add(new Report($"статья об окружающей среде{i}", "окружающая среда очень важна для нас", "Иванов И. И."));
                a.Add(new News($"Трамп победил", "Дональд Трамп победил на выборах в США", b = new DateTime(2016, 11, 20), "New York Times"));
            }

            for (int i = 0; i < a.Count - 1; i++)
            {
                if (a[i] is Ad)
                {
                    Ad b = (Ad)a[i];
                    if (b.delete_date > DateTime.Now)
                        Console.WriteLine(a[i]);
                }
                else
                    Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
