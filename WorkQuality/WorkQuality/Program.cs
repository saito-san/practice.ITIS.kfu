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

            getProducts(ref batch);
            Console.WriteLine($"Quality of batch:{batch.Quality = Batch.Qualify(ref batch)}");
            Console.WriteLine(batch);
            Console.ReadKey();
        }

        static void getProducts(ref Batch batch)
        {
            ItemFactory1<Product> ProductFactory = new ItemFactory1<Product>();
            Random r = new Random();
            Product product;

            ProductDescription description = new ProductDescription();
            description.Article = r.Next(0, int.MaxValue);
            description.StandartTime = new TimeSpan(1, 8, 0);
            description.Title = "изделие";

            for (int i = 0; i < 10; i++)
            {
                product = ProductFactory.GetNewItem();
                product.ReleaseDateTime = DateTime.Now;
                product.Description = description;
                product.Barcode = r.Next(0, int.MaxValue);
                product.IsDefective = (r.Next(0, 1) == 1 ? true : false);
                getWorkLogEntries(ref product);
                batch.Products.Add(product);
            }
        }

        static void getWorkLogEntries(ref Product product)
        {
            ItemFactory2<WorkLogEntry> LogFactory = new ItemFactory2<WorkLogEntry>();
            Random r = new Random();
            WorkLogEntry log;

            for (int i = 0; i < 10; i++)
            {
                log = LogFactory.GetNewItem();
                log.DateTime = DateTime.Now;
                log.Description = $"итерация {i + 1}";
                log.Responsible = $"работник {i + 1}";
                log.TimeSpent = new TimeSpan(0, i + 1 + r.Next(-2, 7), 0);
                product.WorkLogEntries.Add(log);
            }
        }

        class ItemFactory1<WorkLogEntry> where WorkLogEntry : new()
        {
            public WorkLogEntry GetNewItem()
            {
                return new WorkLogEntry();
            }
        }


        class ItemFactory2<Product> where Product : new()
        {
            public Product GetNewItem()
            {
                return new Product();
            }
        }
    }
}
