﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("survey")]
    public IActionResult Results(User user)
    {
        if (ModelState.IsValid)
        {
            return View(user);
        }
        return View("index");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [ResponseCache(Duration =0, Location =ResponseCacheLocation.None,NoStore =true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel{RequestId=Activity.Current?.Id??HttpContext.TraceIdentifier});
    }


}