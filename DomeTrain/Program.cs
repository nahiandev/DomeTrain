namespace DomeTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> fruits_bucket = [
                new("Pineapple", 399),
                new("Strawberry", 450),
                new("Blueberry", 520),
                new("Mango", 475),
                new("Banana", 410),
                new("Avocado", 490),
                new("Coffee", 505),
                new("Coconut", 430),
                new("Grape", 540),
                new("Almond", 525),
                new("Apple", 410),
            ];

            var fruits_exits = fruits_bucket.Any(f => f.Price < 100);
            Console.WriteLine(fruits_exits);


            // Parallel.ForEach(fruits_bucket
            //     .Where(f => f.Price >= 300 && f.Price <= 450)
            //     .OrderBy(n => n.Price).ToList(), fruit => Console.WriteLine(fruit.Name));
        }
    }
}
