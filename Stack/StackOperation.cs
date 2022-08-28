using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    internal class StackOperation
    {
        private int top;
        private int[] element;
        private int max;
        public StackOperation(int size)
        {
            element = new int[size];
            top = -1;
            max = size;
        }
        public void push(int value)
        {   

            if (top == max - 1)
            {
                Console.WriteLine("Stack is overflow");
                return;
            }
            else
            {
                element[++top] = value;   
                Console.WriteLine("{0} Element pushed in stack", element[top]);
                
                
            }
        }
        public int pop()
        {
            
                if (top == -1)
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("{0} is Popped from Stack",  element[top]);
                    return element[top--];
                }

        }
        public int peek()
        {

            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} is top element from Stack", element[top]);
                return element[top];
            }

        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for(int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} Element present in stack", element[i]);
                }
            }
        }
    }
}
