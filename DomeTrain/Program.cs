namespace DomeTrain
{
    class Program
    {
        static void Main()
        {

            var VT = (1, 2, 3, 4, 5, "RE", 'E', true, 1.2, 1.3f);


            List<int> nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

            var (_, max) = MinMax(nums);

            Console.WriteLine(max);
           
        }
        
        private static (int Min, int Max) MinMax(List<int> nums) => (nums.Min(), nums.Max());
        
    }
}
