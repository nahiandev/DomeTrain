namespace DomeTrain

{
    class Program
    {
        static void Main()
        { 
            Lazy<int> lazy = new(static () =>
            {
                const int time = 5;
                for (int i = 0; i < time; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{5 - i} second(s) to generate a random number.");
                }


                return new Random().Next(1, 100);
            });


            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
            Console.WriteLine(lazy.Value);
        }
        
        private static void DoStuff(int x, int y, Calculate math_ops) => Console.WriteLine(math_ops(x, y)); 
        
        delegate int Calculate(int x, int y);
    }
}
