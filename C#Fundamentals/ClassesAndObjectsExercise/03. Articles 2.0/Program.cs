using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void EditContent(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public void RenameArticle(string title) => Title = title;

        public override string ToString() => $"{Title} - {Content}: {Author}";




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article newArticle = new Article(article[0], article[1], article[2]);
                articles.Add(newArticle);   

            }

           // string inputWord = Console.ReadLine();

           
            foreach (var article in articles)
            {
            Console.WriteLine(article);

            }

            

        }
    }
}
