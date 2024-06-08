using Kolokwium.Models;
using Microsoft.AspNetCore.Mvc;
using Zadanie7.DTOs;

namespace Kolokwium.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly Context.Context _context;
    
    public ClientController(Context.Context context)
    {
        _context = context;
    }
    
    [HttpGet(Name = "Clients/{id}")]
    public IActionResult  Get(int id)
    {
        try
        {
            var client = _context.Clients.Find(id);
            var clientDto = new ClientDto(client);
            return Ok(clientDto);
        }
        catch (Exception e)
        {
            return BadRequest();
        }

    }

    [HttpPost(Name = "Clients/{IdClient}/Subscriptions{IdSubscription")]
    public IActionResult tmpname([FromBody] Payment payment, int IdClient, int IdSubscription)
    {
        return Ok(payment);
        //todo
    }
   
}