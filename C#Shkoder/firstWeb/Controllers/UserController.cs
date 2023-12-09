// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace firstWeb.Controllers;   
public class UserController : Controller   // Remember inheritance?    
{      
    [HttpGet("")] 
    public ViewResult Index()        
    {            
     return View("Index");        
    }    

    [HttpGet("user/{name}/{surname}")]
    public ViewResult User2(string name, string surname){

        ViewBag.test="test";
        ViewBag.name= name;
        ViewBag.surname=surname;


        return View();
    }


}

