using System.Text;

namespace _05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string title = Console.ReadLine();
            string content = Console.ReadLine();

            StringBuilder htmlStyle = new StringBuilder();
            htmlStyle.AppendLine("<h1>");
            htmlStyle.AppendLine("\t" + title);
            htmlStyle.AppendLine("</h1>");
            htmlStyle.AppendLine("<article>");
            htmlStyle.AppendLine("\t" + content);
            htmlStyle.AppendLine("</article>");

            string comment;
            while ((comment = Console.ReadLine()) != "end of comments")
            {
                htmlStyle.AppendLine("<div>");
                htmlStyle.AppendLine("\t" + comment);
                htmlStyle.AppendLine("</div>");
            }

            Console.WriteLine(htmlStyle);



            /*  друго решение
             *  
               string title = Console.ReadLine();
            string content = Console.ReadLine();

            List<string> comments = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                comments.Add(input);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"\t {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"\t {content}");
            Console.WriteLine("</article>");

           
            foreach (string comment in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"\t {comment}");
                Console.WriteLine("</div>");
            }

             */
        }
    }
}