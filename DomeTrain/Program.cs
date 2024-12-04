namespace DomeTrain
{
    class Program
    {
        static void Main()
        {

            var VT = (1, 2, 3, 4, 5, "RE", 'E', true, 1.2, 1.3f);


            List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

            var (_, __) = MinMax(nums);

            Console.WriteLine(__);
           
        }
        private static List<int> LambdaOps(int x, int y, List<int> nums, Func<List<int>, int, int, List<int>> operation) => operation(nums, x, y);
        private static bool ValidateAgainstCondition(List<int> collection, int index, Func<List<int>, int, bool> expression) => expression(collection, index);


        private static (int Min, int Max) MinMax(List<int> nums) => (nums.Min(), nums.Max());
        
    }
}
