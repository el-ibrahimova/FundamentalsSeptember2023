namespace _02.Articles
{

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
      

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthot(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] articleStr = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Article article = new Article(articleStr[0], articleStr[1], articleStr[2]);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        string newContent = command[1];
                        article.Edit(newContent);
                        break;
                   
                    case "ChangeAuthor":
                        string newAuthor = command[1];
                        article.ChangeAuthot(newAuthor);
                        break;
                        
                    case "Rename":
                        string newTitle = command[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine(article); //  от override метод

            //  article.Content = "new Pesho in Town"  ==> е едно и също със ==> article.Edit("new Pesho in Town")

        }
    }
}