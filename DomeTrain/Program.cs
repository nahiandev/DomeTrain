using System.Security.Cryptography.X509Certificates;

namespace DomeTrain

{
    class Program
    {
        static void Main()
        {
            // Equivalent to JS self invoking function
            // var result = ((x, y) => x + y)(4, 8)

            int result = ((Func<int, int, int>) ((x, y) => x + y))(4, 8);

            Console.WriteLine(result);
        }

        
        
        private static void DoStuff(int x, int y, Calculate math_ops) => Console.WriteLine(math_ops(x, y));

        private delegate int Calculate(int x, int y);
    }
}
