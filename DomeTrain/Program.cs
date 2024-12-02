namespace DomeTrain
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            List<int> nums = [0,1,2,3,4,5];

            List<int> ints = [6, 7, 8, 9, 0, 1, 2, 3, 4, 5];

            var contains = ListExtension<int>.ContainsRange(ints, nums);

            Console.WriteLine(contains);

            contains = await ListExtension<int>.ContainsRangeAsync(ints, nums);

            Console.WriteLine(contains);
        }
    }
}
