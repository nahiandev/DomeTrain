namespace DomeTrain;

public sealed class Fruits
{
    public static readonly Fruits Instance = new Fruits();

    public readonly List<Product> Bucket = new List<Product>
    {
        new Product("Pineapple", new Random().Next(100, 500)),
        new Product("Strawberry", new Random().Next(100, 500)),
        new Product("Blueberry", new Random().Next(100, 500)),
        new Product("Mango", new Random().Next(100, 500)),
        new Product("Banana", new Random().Next(100, 500)),
        new Product("Avocado", new Random().Next(100, 500)),
        new Product("Coffee", new Random().Next(100, 500)),
        new Product("Coconut", new Random().Next(100, 500)),
        new Product("Grape", new Random().Next(100, 500)),
        new Product("Almond", new Random().Next(100, 500)),
        new Product("Apple", new Random().Next(100, 500))
    };

    private Fruits()
    {
    }
}
