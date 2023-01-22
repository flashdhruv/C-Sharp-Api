using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {

        JsonArray originalJsonAray =  new JsonArray();

        public HomeController(JsonArray originalJsonAray)
        {
            this.originalJsonAray = originalJsonAray;
        }



        //All the magic happens here.
        //"dog" is replaced with "cat" if the value contains that string. 
        //Wasn't sure if case sensitivity was important.
        //Passing the Json Objects in an array seemed like the right way to go. However can be changed for single Object
        public JsonArray ReplaceDogWithCat()
        {
            JsonArray newJsonArray = new JsonArray();

            foreach (JsonObject originalJsonObject in originalJsonAray)
            {
                JsonObject newJsonObject = new JsonObject();
                foreach (var item in originalJsonObject)
                {
                    string value = item.Value.ToString();
                    string[] arrayOfWords = value.Split(' ');
                    for(int i = 0; i < arrayOfWords.Length; i++)
                    {
                        if (string.Compare(arrayOfWords[i], "dog") == 0)
                        {
                            arrayOfWords[i] = "cat";
                        }
                    }
                    string newValue = string.Join(' ', arrayOfWords);
                    newJsonObject.Add(item.Key, newValue);
                }
                newJsonArray.Add(newJsonObject);
            }


            return (newJsonArray);
        }
    }
}
