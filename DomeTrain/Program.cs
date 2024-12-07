using System.Security.Cryptography.X509Certificates;

namespace DomeTrain

{
    class Program
    {
        static void Main()
        {
            List<Func<int, int, int>> operations = [Add, Subtract, Multiply, Divide];

            operations.ForEach(action => {
                Console.WriteLine($"Action name:- {action.Method.Name}, " +
                    $"Result:- {action(12, 10)}");
            });
        }

        private static int Multiply(int x, int y) => x * y;
        private static int Add(int x, int y) => x + y;
        private static int Subtract(int x, int y) => x - y;
        private static int Divide(int x, int y) => x / y;



        private static void DoStuff(int x, int y, Calculate math_ops) => Console.WriteLine(math_ops(x, y));

        private delegate int Calculate(int x, int y);
    }
}
