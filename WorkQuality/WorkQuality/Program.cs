using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkQuality
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Batch batch = new Batch();
            batch.Barcode = r.Next(0, int.MaxValue);
            batch.ReleaseDate = DateTime.Now;

            batch.Products = getProducts();
            Console.WriteLine($"Quality of batch:{batch.Quality = Batch.Qualify(batch)}");
            Console.WriteLine(batch);
            Console.ReadKey();
        }

        static List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            Random r = new Random();
            Product product = new Product();

            ProductDescription description = new ProductDescription();
            description.Article = r.Next(0, int.MaxValue);
            description.StandartTime = new TimeSpan(1, 8, 0);
            description.Title = "изделие";

            product.ReleaseDateTime = DateTime.Now;
            product.Description = description;
            for (int i = 1; i != 10; i++)
            {
                product.Barcode = r.Next(0, int.MaxValue);
                product.IsDefective = (r.Next(0, 1) == 1 ? true : false);
                product.WorkLogEntries = getWorkLogEntries();
                products.Add(product);
            }

            return products;
        }

        static List<WorkLogEntry> getWorkLogEntries()
        {
            List<WorkLogEntry> worklogentries = new List<WorkLogEntry>();
            WorkLogEntry log = new WorkLogEntry();
            Random r = new Random();
            for (int i = 1; i != 10; i++)
            {
                log.DateTime = DateTime.Now;
                log.Description = $"выполнение итерации {i}";
                log.Responsible = $"работник {i}";
                log.TimeSpent = new TimeSpan(0, i + r.Next(-1, 4), 0);
                worklogentries.Add(log);
            }

            return worklogentries;
        }
    }
}
