using System.Text;

namespace DomeTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fruits_bucket = Fruits.Instance.Bucket.AsQueryable();
            
            fruits_bucket.Where(f => f.Price <= 200).ToList().ForEach(Console.WriteLine);


            var empty = new List<int> { 3, 4,3,6,3,7};


            empty.ForEach(Console.WriteLine);
        }
    }
}
