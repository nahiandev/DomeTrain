namespace DomeTrain
{
    class Program
    {
        static void Main()
        { 
            List<int> nums = [1, 2, 3, 4, 5, 7, 2, 43, 65, 7, 6, 23, 
                543, 6, 57, 54, 23, 2, 234, 643];
            //var result = LambdaOps(500, 600, nums, (n, x, y) => n.Where(a => a > x && a < y)
            //.ToList());

            //result.ForEach(Console.WriteLine); 

            const int value = 5;

            var flag = ActionOps(nums, value, (n, v) => n.IndexOf(v) is not -1);


            Console.WriteLine(flag);
        }
        private static List<int> LambdaOps(int x, int y, List<int> nums, 
            Func<List<int>, int, int, List<int>> operation) => operation(nums, x, y);


        private static bool ActionOps(List<int> collection, int index, Func<List<int>, int, bool> expression) => expression(collection, index);
    }
}
