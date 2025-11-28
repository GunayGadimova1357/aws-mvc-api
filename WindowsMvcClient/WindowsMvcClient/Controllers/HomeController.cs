// using System.Diagnostics;
// using Microsoft.AspNetCore.Mvc;
// using WindowsMvcClient.Models;
//
// namespace WindowsMvcClient.Controllers;
//
// public class HomeController : Controller
// {
//     private readonly ILogger<HomeController> _logger;
//
//     public HomeController(ILogger<HomeController> logger)
//     {
//         _logger = logger;
//     }
//
//     public IActionResult Index()
//     {
//         return View();
//     }
//
//     public IActionResult Privacy()
//     {
//         return View();
//     }
//
//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }
using Microsoft.AspNetCore.Mvc;
using WindowsMvcClient.Services;

public class HomeController : Controller
{
    private readonly ApiService _api;

    public HomeController(ApiService api)
    {
        _api = api;
    }

    public async Task<IActionResult> Index()
    {
        var message = await _api.GetHelloAsync();
        ViewBag.ApiMessage = message;
        return View();
    }
}
