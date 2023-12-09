// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Portfolio1.Controllers;   
public class PortfolioController : Controller   // Remember inheritance?
{
    [HttpGet("")]
    public ViewResult Index (){
        return View("Index");

    }
    [HttpGet("projects")]
    public ViewResult Projects(){
        return View("Projects");
    }
    [HttpGet("contact")] 
    public ViewResult Contacts(){
        return View("Contacts");
    }
}   
