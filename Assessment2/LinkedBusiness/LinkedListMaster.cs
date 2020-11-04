using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Utilities;

namespace LinkedBusiness
{
    public class LinkedListMaster : ILinkedListMaster
    {
        ILinkedListProcess _linkedlistprocess;
        public LinkedListMaster(ILinkedListProcess linkedlistprocess)
        {
            _linkedlistprocess = linkedlistprocess;
        }
        public LinkedListMaster()
        {

        }
        /// <summary>
        /// Process Data.  Creates the singly linked list 
        /// and returns the 5th interger
        /// </summary>
        /// <returns>int</returns>
        public int ProcessData()
        {
            int fifthelement = 0;

            _linkedlistprocess.AddtoList(3);
            _linkedlistprocess.AddtoList(4);
            _linkedlistprocess.AddtoList(5);
            _linkedlistprocess.AddtoList(6);
            _linkedlistprocess.AddtoList(8);
            _linkedlistprocess.AddtoList(9);
            _linkedlistprocess.AddtoList(1);
            _linkedlistprocess.AddtoList(2);

            return fifthelement = _linkedlistprocess.Getthe_nth(5);
        }

        /// <summary>
        /// Process Data Strings.  Creates the singly linked list 
        /// and returns the 5th string
        /// </summary>
        /// <returns>string</returns>
        public string ProcessDataStrings()
        {
            string fifthStringelement;

            _linkedlistprocess.AddstringtoList("Cow");
            _linkedlistprocess.AddstringtoList("Sheep");
            _linkedlistprocess.AddstringtoList("Horse");
            _linkedlistprocess.AddstringtoList("Duck");
            _linkedlistprocess.AddstringtoList("Pig");
            _linkedlistprocess.AddstringtoList("Goat");
            _linkedlistprocess.AddstringtoList("Donkey");

            return fifthStringelement = _linkedlistprocess.Getthe_nthstring(5);
        }
    }
}

