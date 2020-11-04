using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Utilities
{
    public class LinkedListProcess : ILinkedListProcess
    {
        Node head;
        /// <summary>
        /// Initialize the linked list constructor
        /// </summary>
        public LinkedListProcess()
        {
            head = null;
        }

        /// <summary>
        /// Returns the 5th interger in the singly linked list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Getthe_nth(int index)
        {
            Node curr = head;
            int cnt = 0;

            while (curr != null)
            {
                if (cnt == index)
                    return curr.data;
                cnt++;
                curr = curr.next;
            }

            return 0;
        }

        /// <summary>
        /// Returns the 5th string in the singly linked list
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string Getthe_nthstring(int index)
        {
            Node curr = head;
            int cnt = 0;

            while (curr != null)
            {
                if (cnt == index)
                    return curr.strdata;
                cnt++;
                curr = curr.next;
            }

            return "Error";
        }

        /// <summary>
        /// Adds the data(int) to the singly linked list of intergers
        /// </summary>
        /// <param name="data"></param>
        public void AddtoList(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        /// <summary>
        /// Adds the data(string) to the singly linked list of strings
        /// </summary>
        /// <param name="data"></param>
        public void AddstringtoList(string data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }
    }
}
