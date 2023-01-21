using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string json = "{\"name\":\"dog\",\"breed\":\"Golden Retriever\"}";
            var expectedJson = "{\"name\":\"cat\",\"breed\":\"Golden Retriever\"}";
            var homeController = new HomeController();
        }
    }
}
