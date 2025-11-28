using Microsoft.AspNetCore.Mvc;

namespace LinuxWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello from Linux API!";
    }
}