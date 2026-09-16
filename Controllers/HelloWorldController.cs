using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 

    // // GET: /HelloWorld/Welcome/ 
    // // Requires using System.Text.Encodings.Web;
    // // URL: http://localhost:5217/helloworld/welcome/3?name=Daniel&numtimes=4
    // // OR - URL:http://localhost:5217/helloworld/welcome?name=Daniel&numtimes=4&id=2
    // public string Welcome(string name, int numTimes = 1, int id = 1)
    // {
    //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID is: {id}");
    // }

    public IActionResult Welcome(string name, int numTimes = 1, int id = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        ViewData["ID"] = id;

        if (id == 1)
        {
            return Content("User Id should be greater than 1");
        }

        return View();
    }
}