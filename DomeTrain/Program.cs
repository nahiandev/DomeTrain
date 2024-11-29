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
           
           
            var selected_fruits = fruits_bucket
                .Where(f => f.Price > 300 && f.Price < 450)
                .OrderBy(n => n.Price).ToList();

            Parallel.ForEach(selected_fruits, fruit => Console.WriteLine(fruit.Name));
        }
    }
}
