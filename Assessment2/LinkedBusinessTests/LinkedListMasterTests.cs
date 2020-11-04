using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using LinkedList.Utilities;

namespace LinkedBusiness.Tests
{
    [TestClass()]
    public class LinkedListMasterTests
    {
        [TestMethod()]
        public void ProcessDataTest()
        {
            //Setup
            Mock<ILinkedListProcess> ll = new Mock<ILinkedListProcess>();
            ll.Setup(x => x.Getthe_nth(5)).Returns(8);
            var linkedlistlogicobj = new LinkedListMaster(ll.Object);

            //Act
            int intresult = linkedlistlogicobj.ProcessData();

            //Assert
            Assert.AreEqual(8, intresult);
        }

        [TestMethod()]
        public void ProcessDataStringsTest()
        {
            //Setup
            Mock<ILinkedListProcess> ll = new Mock<ILinkedListProcess>();
            ll.Setup(x => x.Getthe_nthstring(5)).Returns("Cow");
            var linkedlistlogicobj = new LinkedListMaster(ll.Object);

            //ACT
            string strresult = linkedlistlogicobj.ProcessDataStrings();

            //Assert
            Assert.AreEqual("Cow", strresult);
        }
    }
}