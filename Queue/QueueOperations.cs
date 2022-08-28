using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueOP
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class QueueOperations
    {
        Node front = null, rear = null;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (this.front == null)
            {
                newnode.next = null;
                this.front = newnode;
                this.rear = newnode;
            }
            else
            {
                this.rear.next = newnode;
                this.rear = newnode;
            }
            Console.WriteLine("Enqueued {0}", data);
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Empty queue");
                return;
            }
            Console.WriteLine("Dequeued {0}", this.front.data);
            this.front = this.front.next;
        }
        public void Display()
        {
            Node temp = this.front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine(" ");
        }

    }
}
