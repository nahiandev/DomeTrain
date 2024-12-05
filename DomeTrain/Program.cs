namespace DomeTrain
{
    class Program
    {
        static void Main()
        { 
            DoStuff(1, 2, (x, y) => x + y);

            DoStuff(3, 4, (x, y) => x * y);

            DoStuff(7, 6, (x, y) => x * y);

            DoStuff(7, 5, (x, y) => Convert.ToInt32(string.Join("", [x, y]))); 
        }
        
        private static void DoStuff(int x, int y, Calculate math_ops) => Console.WriteLine(math_ops(x, y)); 
        delegate int Calculate(int x, int y);
    }
}
