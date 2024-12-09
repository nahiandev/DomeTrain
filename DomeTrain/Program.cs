using System.Runtime.CompilerServices;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            var text = "Hello World!";

            Console.WriteLine(text.GetUTF8Bytes());
        }
    }
}
