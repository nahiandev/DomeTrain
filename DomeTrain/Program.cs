namespace DomeTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fruits_bucket = Fruits.Bucket;

            var fruits_exits = fruits_bucket.Any(f => f.Price < 100);
            Console.WriteLine(fruits_exits);


            // Parallel.ForEach(fruits_bucket
            //     .Where(f => f.Price >= 300 && f.Price <= 450)
            //     .OrderBy(n => n.Price).ToList(), fruit => Console.WriteLine(fruit.Name));
        }
    }
}
