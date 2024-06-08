using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    
    [HttpGet(Name = "doctors")]
    public string  Get()
    {
        return "works";
    }
   
}