using System.Text;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            string text = "Hello World!";

            var bytes = Encoding.UTF8.GetBytes(text);

            Console.WriteLine($"Converted bytes: {string.Join(".", bytes)}");

            string reform_text = Encoding.UTF8.GetString(bytes);

            Console.WriteLine($"Reformed text from bytes: {reform_text}");
        }
    }
}
