using System.IO.Compression;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            Instance r = new();

            r.PrintConsoleBase();
            r.PrintConsole();

            Console.WriteLine(r is Base);
        }
    }
}
