namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------> Linked List Operations <-----------------");
            Console.WriteLine("\n--------------> Create Linked List <-----------------");
            LinkedListOperations add = new LinkedListOperations();
            add.InsertAtFirst(70);
            add.InsertAtFirst(30);
            add.InsertAtFirst(56);
            add.Display();
            Console.WriteLine("\n--------------> Add Value in Linked List <-----------------");
            LinkedListOperations add2 = new LinkedListOperations();
            add2.InsertAtLast(56);
            add2.InsertAtLast(30);
            add2.InsertAtLast(70);
            add2.Display();
            Console.WriteLine("\n--------------> Append Value IN linked list <-----------------");
            LinkedListOperations Linked = new LinkedListOperations();
            Linked.InsertAtFirst(56);
            Linked.InsertAtLast(70);
            Linked.InsertAtIndex(30, 1);
            Linked.Display();

            Console.WriteLine("\n--------------> Delete from last  <-----------------");
            Linked.DeleteLast();
            Linked.Display();
            Console.WriteLine("\n--------------> Delete value from first <-----------------");
            Linked.DeleteFirst();
            Linked.Display();

            Console.WriteLine("\n--------------> insert at first <-----------------");
            Linked.InsertAtFirst(56);
            Console.WriteLine("Index of {0} ", Linked.GetIndexOf(30));

            Console.WriteLine("\n--------------> Insert at last <-----------------");
            Linked.AddAfter(40, 30);
            Linked.Display();

            Console.WriteLine("\n--------------> Delete specific value <-----------------");
            Linked.DeleteValue(40);
            Linked.Display();

            Console.WriteLine("\n--------------> Calculte length of linked list <-----------------");
            Console.WriteLine("Length : {0}", Linked.Length());


            Console.WriteLine("\n--------------> Sort  the linked list <-----------------");
            Linked.InsertAtLast(20);
            Linked.InsertAtLast(10);
            Linked.InsertAtLast(95);
            Linked.Display();
            Linked.SortList();
            Linked.Display();
        }
    }
}