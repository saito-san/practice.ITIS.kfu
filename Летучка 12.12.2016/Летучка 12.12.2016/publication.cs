using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Летучка_12._12._2016
{
    public class Publication
    {
        public string header { get; set; }
        public string text { get; set;  }

        public Publication(string header, string text)
        {
            this.header = header;
            this.text = text;
        }

        public override string ToString()
        {
            return String.Format($"{header}\n{text}");
        }
    }

    public class News : Publication
    {
        public DateTime date { get; set; }
        public string istochnik { get; set; }

        public News( string header, string text, DateTime date, string istochnik) : base(header, text)
        {
            this.date = date;
            this.istochnik = istochnik;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return String.Format($"дата публикации: {date}\nисточник: {istochnik}\n\n");
        }
    }

    public class Ad : Publication
    {
        public DateTime post_date { get; set; }
        public DateTime delete_date { get; set; }

        public Ad(string header, string text, DateTime post_date, DateTime delete_date) : base(header, text)
        {
            this.post_date = post_date;
            this.delete_date = delete_date;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return String.Format($"дата публикации: {post_date}\nдата окончания: {delete_date}\n\n");

        }
    }

    public class Report : Publication
    {
        public string author { get; set; }

        public Report(string header, string text, string author) : base(header, text)
        {
            this.author = author;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return String.Format($"автор: {author}\n\n");
        }
    }
}
