
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
