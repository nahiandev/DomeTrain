namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            List<Func<int, int, int>> operations = [Add, Subtract, Multiply, Divide, Concat];

            operations.ForEach(action => {
                Console.WriteLine($"Action name:- {action.Method.Name}, " +
                    $"Result:- {action(12, 10)}");
            });


            // DoStuff(9, 5, (x, y) => x * 10 + y);
        }

        private static int Multiply(int x, int y) => x * y;
        private static int Add(int x, int y) => x + y;
        private static int Subtract(int x, int y) => x - y;
        private static int Divide(int x, int y) => x / y;
        private static int Concat(int x, int y) => int.Parse($"{x}{y}");



        private static void DoStuff(int x, int y, Calculate expression) => Console.WriteLine(expression(x, y));

        private delegate int Calculate(int x, int y);
    }
}
