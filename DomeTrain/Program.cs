using System.Globalization;
using System.Runtime.InteropServices;

namespace DomeTrain
{
    class Program
    {
        static void Main()
        {
            int result = ((Func<List<int>, int>) (nums => nums.Sum()))([..NumsGen(1000)]);

            Console.WriteLine(result);
        }

        private static IEnumerable<int> NumsGen(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                yield return i;
            }
        }

        private static long CumulativePalindrome(int num)
        {
            if (IsPalindrome(num.ToString())) return num;

            long sum = 0;

            while (!IsPalindrome(sum.ToString()))
            {
                sum += (num + long.Parse(Reverse(num.ToString())));
            }
            
            return sum;
        }

        private static bool IsPalindrome(string input)
        {
            if (input.Length is 1 or 0) return true;
            
            //return string.Compare(input, Reverse(input.ToLower()), StringComparison.OrdinalIgnoreCase) is 0;   
            return string.CompareOrdinal(input, Reverse(input)) == 0;
        }

        private static string Reverse(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        private static long EulerSum(int x, int y, int limit)
        {
            long sum = 0;

            for (var i = 0; i < limit; i++)
            {
                if (i % x is 0 || i % y is 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
