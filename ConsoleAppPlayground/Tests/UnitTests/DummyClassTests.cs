using ConsoleAppPlayground.Playground.Trash;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Tests.UnitTests
{
    [TestClass]
    public class DummyClassTests
    {
        [TestMethod]
        public void Should_Return_Four() 
        {
            DummyClass dummyClass = new DummyClass();
            Assert.AreEqual(4, dummyClass.Add(2, 2));
        }

        // add mocks 
        // add xunit usage 
    }
}
