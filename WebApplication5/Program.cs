using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using WebApplication5.Controllers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// The route is from localhost to localhost/replaceDogWithCat
// Payload is passed through the body and sent to the controller to be dealt with 
app.MapGet("/replaceDogWithCat",  ([FromBody] JsonArray json) =>
{
    var homeController = new HomeController();
    var response = homeController.ReplaceDogWithCat(json);
    return response;
    
}); 

app.Run();