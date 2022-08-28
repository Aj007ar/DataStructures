namespace QueueOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Queue Operations");
            QueueOperations queue = new QueueOperations();
            Console.WriteLine("\n---------------------> Enqueue Operations <-------------------------");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("After Enqueue");
            queue.Display();
            Console.WriteLine("\n---------------------> Dequeue Operations <-------------------------");
            Console.WriteLine("Dequeue");
            queue.Dequeue();
            Console.WriteLine("After Dequeue");
            queue.Display();
        }
    }
}