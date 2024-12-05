using System.Text;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            DoStuff(7, 5, (x, y) => x * y);
        }

        private static void DoStuff(int x, int y, Calculate math_ops) => Console.WriteLine(math_ops(x, y));

        delegate int Calculate(int x, int y);
    }
}
