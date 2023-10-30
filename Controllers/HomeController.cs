using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidations.Models;

namespace DojoSurveyWithValidations.Controllers;

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

    [HttpGet]
    [Route("results")]
    public IActionResult ResultSurvey(Survey survey)
    {
        Console.WriteLine(survey.Name);
        return View(survey);

    }

    [HttpPost]
    [Route("process")]
    public IActionResult ProcessSurvey (Survey survey)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine("si");
            return RedirectToAction("ResultSurvey", survey);
        }

        Console.WriteLine("Not valid");
        return View("Index");
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
