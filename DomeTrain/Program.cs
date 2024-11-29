namespace DomeTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fruits_bucket = Fruits.Instance.Bucket;
            
            ICollection<Product> selected_fruits = fruits_bucket
                .Where(f => f.Price is >= 100 and <= 300)
                .OrderBy(n => n.Price).ToList();

            int total_price = selected_fruits.Sum(f => f.Price);
            int total_fruits = selected_fruits.Count;
            Parallel.ForEach(selected_fruits, fruit =>
            {
                Console.WriteLine($"{fruit.Name} -> {fruit.Price}");
            });
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Total fruits: {total_fruits}");
            Console.WriteLine($"Total price: {total_price}");
        }
    }
}
