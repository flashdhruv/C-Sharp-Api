using System.Text.Json.Nodes;
using System.Web.Http.Results;
using WebApplication5.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Complete test for the API
        //Creates a JsonArray and an expected result
        //Checks for comparison.
        [TestMethod]
        public void TestReplaceDogWithCat()
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

            var homeController = new HomeController(jArray);

            var result = homeController.ReplaceDogWithCat();
            Assert.AreEqual(result[0].ToString() , ExpectedjArray[0].ToString());
            
        }
    }
}