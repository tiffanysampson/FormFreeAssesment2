using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// Node class for adding to linked list
    /// </summary>
    public class Node
    {
        public int data;
        public Node next;
        public string strdata;

        public Node(int t)
        {
            data = t;
            next = null;
        }
        public Node(string s)
        {
            strdata = s;
            next = null;
        }


    }
}
