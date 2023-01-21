using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using System.Web.Http.Results;
using WebApplication5.Controllers;

namespace WebApplication5.UnitTests
{
    [TestClass]
    public class UnitTest
    {
        //Unit test to check if the arrays would match
        [TestMethod]
        public void TestMethod1()
        {
            JsonArray jArray = new JsonArray();
            JsonObject jObject = new JsonObject();
            jObject.Add("type", "dog");
            jObject.Add("name", "doggy doggerson");
            jArray.Add(jObject);

            JsonArray ExpectedjArray = new JsonArray();
            JsonObject ExpectedjObject = new JsonObject();
            ExpectedjObject.Add("type", "cat");
            ExpectedjObject.Add("name", "catgy catgerson");
            ExpectedjArray.Add(ExpectedjObject);

            var homeController = new HomeController();

            var result = homeController.ReplaceDogWithCat(jArray) as OkNegotiatedContentResult<JsonArray>;
            Assert.AreEqual(result, ExpectedjArray);
            
        }
    }
}
