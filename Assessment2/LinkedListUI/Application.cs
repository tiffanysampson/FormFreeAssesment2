using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedBusiness;

namespace LinkedListUI
{
    public class Application : IApplication
    {
        ILinkedListMaster _linkedlistmaster;
        public Application(ILinkedListMaster linkedlistmaster)
        {
            _linkedlistmaster = linkedlistmaster;
        }
        /// <summary>
        /// Application startup
        /// </summary>
        public void Run()
        {
            int intResults = _linkedlistmaster.ProcessData();
            string strResults = _linkedlistmaster.ProcessDataStrings();
            Console.WriteLine(intResults.ToString());
            Console.WriteLine(strResults.ToString());
            Console.ReadLine();
        }

    }
}
