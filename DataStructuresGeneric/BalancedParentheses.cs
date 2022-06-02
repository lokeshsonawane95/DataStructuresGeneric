using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGeneric
{
    internal class BalancedParentheses<T> where T : IComparable
    {
        internal Node<T> top;

        //For pushing/(adding node at first position) the node onto the stack
        internal void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
                Console.WriteLine(" \"" + newNode.data + "\" is pushed onto the stack");
            }
            top = newNode;
        }

        //For peeking stack
        internal char Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return ' ';
            }
            if (top.data.CompareTo('(') == 0)
            {
                return '(';
            }
            return ' ';
        }

        //For popping/(deleting first) node from the stack
        internal void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(" \"" + top.data + "\" is popped from the stack");
            top = top.next;
        }

        //For displaying the stack
        internal void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("The stack contains :\n");
            Console.Write(" top ->");
            Node<T> tempNode = top;
            while (tempNode != null)
            {
                Console.WriteLine("\t| " + tempNode.data + " |");
                tempNode = tempNode.next;
            }
            Console.WriteLine();
        }
    }
}
