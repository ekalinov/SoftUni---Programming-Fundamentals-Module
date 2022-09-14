using System;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {   
            this.Title = title;
            this.Content = content; 
            this.Author = author;   
        }
        public string Title  { get; set; }
        public string Content { get; set; }
        public string Author  { get; set; }

        public void EditContent(string content)=> Content = content;

        public void ChangeAuthor(string author)=> Author = author;

        public void RenameArticle(string title) =>Title = title;

        public override string ToString()=> $"{Title} - {Content}: {Author}";
       
        


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article newArticle = new Article(article[0], article[1], article[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputCommand = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string command = inputCommand[0];

                if (command=="Edit")
                {
                    newArticle.EditContent(inputCommand[1]);
                }
                else if (command == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(inputCommand[1]);
                }
                else if (command == "Rename")
                {
                    newArticle.RenameArticle(inputCommand[1]);
                }
                

            }

            Console.WriteLine(newArticle);
        }
    }
}
