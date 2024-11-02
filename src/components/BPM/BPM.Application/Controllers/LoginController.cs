using BPM.Domain.Types.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BPM.Application.Controllers;
[Produces("application/json")]
[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    
    private readonly ILogger<LoginController> _logger;

    private static List<LoginRequest> list = new List<LoginRequest>();
   

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }
    
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [HttpPost(Name = "login")]
    public IActionResult Login(LoginRequest request)
    {
        list.Add(request);
        return Ok($" Email: {request.Email} \n Password: {request.Password}");

    }
    
    [HttpGet("")]
    public IActionResult GetUser()
    {
        return Ok(list);
    }
    
    
}
