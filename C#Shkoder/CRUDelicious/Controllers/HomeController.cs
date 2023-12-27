using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger,MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.listaMeDish = _context.Dishes.ToList();
        return View();
    }
    [HttpGet("AddDish")]
    public IActionResult AddDish(){
        return View();
    }
    [HttpPost("CreateDish")]
    public IActionResult CreateDish(Dish dishNgaForma){

        if (ModelState.IsValid)
        {
            _context.Add(dishNgaForma);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View("AddDish");

    }
    
    [HttpGet("Dish/{id}")]
    public IActionResult Dish(int id){
        Dish gatimi = _context.Dishes.FirstOrDefault(e => e.DishId == id);
        return View(gatimi);
    }
    
    [HttpGet("Delete/{id}")]
    public IActionResult Delete(int id){
         Dish gatimiQeDoFshi = _context.Dishes.FirstOrDefault(e=> e.DishId == id);
         _context.Remove(gatimiQeDoFshi);
         _context.SaveChanges();
         return RedirectToAction("Index");
    }

    [HttpGet("Dish/{id}/EditDish")]
    public IActionResult EditDish (int id){
        Dish dishFromDb = _context.Dishes.FirstOrDefault(e=>e.DishId == id);
        return View("EditDish",dishFromDb);
    }
    [HttpPost("UpdateDish/{id}")]
    public IActionResult Update(Dish dishFromForm, int id){
        Dish dishFromDb = _context.Dishes.FirstOrDefault(e=> e.DishId == id);
        if (ModelState.IsValid){
            dishFromDb.Chef = dishFromForm.Chef;
            dishFromDb.Name = dishFromForm.Name;
            dishFromDb.Calories = dishFromForm.Calories;
            dishFromDb.Tastiness = dishFromForm.Tastiness;
            dishFromDb.Description = dishFromForm.Description;
            dishFromDb.UpdatedAt = dishFromForm.UpdatedAt;
            _context.SaveChanges();
            
            return RedirectToAction("Dish", new {id = id});
        }
        return View("EditDish", dishFromDb);
    }
    
   
    public IActionResult Privacy()

    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
