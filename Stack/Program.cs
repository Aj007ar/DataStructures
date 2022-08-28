namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome  to Stack operations");
            StackOperation stackOperation = new StackOperation(5);
            Console.WriteLine("\n--------------> Push Elements <--------------------");
            stackOperation.push(70);
            stackOperation.push(30);
            stackOperation.push(56);
            Console.WriteLine("\n--------------> Pop Elements <--------------------");
            stackOperation.pop();
            Console.WriteLine("\n--------------> Peek Elements <--------------------");
            stackOperation.peek();
            Console.WriteLine("\n--------------> View All Elements <--------------------");
            stackOperation.Display();
        }
    }
}