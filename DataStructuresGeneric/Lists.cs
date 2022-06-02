using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGeneric
{
    internal class Lists<T> where T : IComparable
    {
        public int flag = 0;

        //For storing the address of first element
        internal Node<T> head;

        //For adding node at the last position
        internal void Append(T data)
        {
            Node<T> node = new Node<T>(data);

            //Checking if head is pointing to null value or not
            if (head == null)
            {
                //If head is pointing to null then add the entered element as first element
                head = node;
            }
            else
            {
                //Declared temporary node tempHead pointing to head
                Node<T> tempHead = head;

                //while we dont't get next value of node as null
                while (tempHead.next != null)
                {
                    //tempHead is moving to next node
                    tempHead = tempHead.next;
                }
                //assigning next of last element (here temp) to newly added "node"
                tempHead.next = node;
            }
        }

        //For deleting a specific value from the list
        //To delete a specific node we have to find/search the node present before the node we want to delete
        internal void DeleteValue(T search)
        {
            Node<T> tempHead = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            //while temporary head's (tempHead) next node's data is not entered value
            while (tempHead.next != null)
            {
                //If our desired value is found in the list after which we want to insert our node
                if (tempHead.next.data.CompareTo(search) == 0)
                {
                    tempHead.next = tempHead.next.next;

                }
                tempHead = tempHead.next;
            }
            Console.WriteLine("\nEvery occurance of the value \"" + search + "\" is deleted from the list\n");
        }

        //For searching a node
        internal void Search(T search)
        {
            Node<T> tempHead = head;

            if (tempHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                while (tempHead.next != null)
                {
                    //If our desired value is found in the list
                    if (tempHead.data.CompareTo(search) == 0)
                    {
                        flag = 1;
                        Console.WriteLine("The value \"" + search + "\" is present in the linked list");
                        return;
                    }
                    //If our desired value does not found in the list
                    tempHead = tempHead.next;
                }
                if (flag == 0)
                {
                    Console.WriteLine("The value \"" + search + "\" is not present in the linked list");
                    return;
                }
            }
        }

        //For displaying all elements in Linked List
        internal void Display()
        {
            //Temporary node tempHead is declared and it is pointing to head
            Node<T> tempHead = head;

            //Linked List empty condition
            if (tempHead == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Console.WriteLine("Values present in the linked list are : ");

                //while currentNode's value does not become null
                while (tempHead != null)
                {
                    //Printing the data to which tempHead is pointing
                    Console.Write(tempHead.data + " ");

                    //we are moving current node to next position/address
                    tempHead = tempHead.next;
                }
                Console.WriteLine();
            }
        }
    }
}
