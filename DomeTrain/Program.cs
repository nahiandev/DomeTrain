namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            var sum = EulerSum(3, 5, 100);

            Console.WriteLine(sum);
        }

        private static long EulerSum(int x, int y, int limit)
        {
            long sum = 0;

            for (int i = 0; i < limit; i++)
            {
                if(i % x is 0 || i % y is 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
