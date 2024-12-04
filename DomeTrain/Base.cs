using System.Threading.Channels;

namespace DomeTrain
{
    public class Base
    {
        // public virtual void Print(string text);

        public virtual void PrintConsole() => Console.WriteLine("Base class method.");
    }

    public class Instance : Base
    {
        public void PrintConsoleBase() => base.PrintConsole();

        // public override void PrintConsole() => base.PrintConsole();

        public override void PrintConsole() => Console.WriteLine("Derived class method.");
    }
}
