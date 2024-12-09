﻿namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            List<string> str_nums = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];

            List<int> nums = str_nums.Select(int.Parse).ToList();
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
