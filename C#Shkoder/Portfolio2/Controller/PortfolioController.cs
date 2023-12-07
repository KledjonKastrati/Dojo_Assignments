// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Portfolio2.Controllers;   
public class PortfolioController : Controller   // Remember inheritance?
{
    [HttpGet]
    [Route ("")]
    public ViewResult Index (){
        return View("index");

    }
    [HttpGet("projects")]
    public ViewResult Projects(){
        return View("projects");
    }
    [HttpGet("contacts")] 
    public ViewResult Contacts(){
        return View("contacts");
    }
}   