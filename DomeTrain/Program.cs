using System.Text;

namespace DomeTrain
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person john = new() { Name = "John", Age = 30 };

            Person alex = new Person { Name = "Alex", Age = 20 };

            Person maria = new("Maria", 25);

            List<Person> list = [];

            list.AddRange(john, alex, maria);

            list.OrderBy(static x => x.Age).ToList().
                ForEach(static p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
