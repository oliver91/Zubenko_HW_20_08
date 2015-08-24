using System;
using System.Security;

namespace Arrays_Task2
{
    class Program
    {
        static void Main()
        {
            Store store = new Store();
            store.AddToStore(new Article("iphone", "notus", 700));
            store.AddToStore(new Article("sony z3", "notus", 750));
            store.AddToStore(new Article("nokia lumia", "notus", 550));
            store.AddToStore(new Article("htc one", "notus", 600));
            store.PrintAllArticles();
            Console.WriteLine("\n");
            Console.WriteLine("article with index 1: ");
            Console.Write("\t");
            store.PrintArticle(1);

            Console.WriteLine("Enter article name: ");
            string artName = Console.ReadLine();
            store.PrintArticle(artName);

            Console.ReadKey();
        }
    }

    internal class Article
    {
        private string articleName;
        private string shopName;
        private double price;

        public string ArticleName 
        {
            get { return articleName; }
        }

        public Article this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public Article(string name, string shop, double price)
        {
            this.articleName = name;
            this.shopName = shop;
            this.price = price;
        }

        public string ShowInfo()
        {
            return string.Format("article: {0}, price: {1}, shop: {2}", articleName, price, shopName);
        }
    }

    internal class Store
    {
        private Article[] articles = null;

        public void AddToStore(Article a)
        {
            if (articles != null)
            {
                Article[] tmp = new Article[articles.Length];
                articles.CopyTo(tmp, 0);
                articles = new Article[articles.Length + 1];
                tmp.CopyTo(articles, 0);
                articles[articles.Length-1] = a;
            }
            else
            {
                articles = new Article[1];
                articles[0] = a;
            }
        }

        public void PrintArticle(int index)
        {
            Console.WriteLine(articles[index].ShowInfo());
        }

        public void PrintArticle(string name)
        {
            bool isFound = false;
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].ArticleName.Equals(name))
                {
                    PrintArticle(i);
                    isFound = true;
                }
            }
            if (isFound == false) Console.WriteLine("article not found!");
        }

        public void PrintAllArticles()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                PrintArticle(i);
            }
        }
    }
}
