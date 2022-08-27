using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListOperations
    {
        private Node Head;
        private Node Tail;
        int Size;

        public int Length()
        {
            return Size;
        }

        public int Last()
        {
            return Tail.Value;
        }

        public void Display()
        {
            var temp = Head;

            while (temp != null)
            {
                Console.Write(" {0} -> ", temp.Value);
                temp = temp.Next;
            }
            Console.WriteLine("LAST NODE");
        }
        public void InsertAtFirst(int item)
        {
            var newNode = new Node(item);
            if (Head == null)
                Head = Tail = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Size += 1;
        }
        public void InsertAtLast(int item)
        {
            var newNode = new Node(item);
            if (Head == null)
                Head = Tail = newNode;
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Size += 1;
        }
        public void InsertAtIndex(int item, int index)
        {
            if (index < 0 || index > Size)
                Console.WriteLine("Index provided is out of range.");

            else if (index == 0)
                InsertAtFirst(item);

            else if (index == Size)
                InsertAtLast(item);

            else
            {
                var temp = Head;
                for (int i = 1; i < index; i++)
                {
                    temp = temp.Next;
                }

                var newNode = new Node(item);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                Size++;
            }
        }
        public void GetItemAt(int index)
        {
            var temp = Find(index + 1);
            Console.WriteLine(temp.Value);
        }

        public int GetIndexOf(int value)
        {
            var count = 0;
            var temp = Head;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    return count;
                }
                temp = temp.Next;
                count++;
            }
            return count;
        }
        public void AddAfter(int valueAdd, int afterValue)
        {
            var index = GetIndexOf(afterValue);
            InsertAtIndex(valueAdd, index + 1);
        }

        private Node Find(int index)
        {
            if (index < 1 || index >= Size)
                throw new ArgumentOutOfRangeException();
            var temp = Head;
            for (int i = 1; i < index; i++)
                temp = temp.Next;
            return temp;
        }
        public void DeleteFirst()
        {
            if (Head == Tail)
                Head = Tail = null;
            else
            {
                var temp = Head.Next;
                Head = temp;
                Size--;
            }
        }

        public void DeleteLast()
        {
            if (Head == Tail)
                Head = Tail = null;
            else
            {
                var temp = Find(Size - 1);
                Tail = temp;
                Tail.Next = null;
                Size--;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index == 0)
                DeleteFirst();
            else if (index == Size - 1)
                DeleteLast();
            else
            {
                var temp = Find(index);
                temp.Next = temp.Next.Next;
            }
        }

        public void DeleteValue(int value)
        {
            var index = GetIndexOf(value);
            DeleteAtIndex(index);
        }

        public void SortList()
        {
            var previous = Head;
            var current = Head.Next;

            while (current != null)
            {
                if (current.Value < previous.Value)
                {
                    previous.Next = current.Next;
                    current.Next = Head;
                    Head = current;

                    current = previous;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }
    }
}
