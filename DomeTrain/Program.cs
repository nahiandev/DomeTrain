using System.Text;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            string text = "Hello こんにちは世界";

            var bytes = Encoding.UTF32.GetBytes(text);

            Console.WriteLine($"Converted bytes: {string.Join("", bytes)}");

            string reform_text = Encoding.UTF32.GetString(bytes);

            Console.WriteLine($"Reformed text from bytes: {reform_text}");
        }
    }
}
