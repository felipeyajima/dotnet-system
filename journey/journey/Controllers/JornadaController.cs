using Microsoft.AspNetCore.Mvc;

namespace journey.Controllers;

[ApiController]
[Route("[controller]")]
public class JornadaController : ControllerBase
{
    
    private readonly ILogger<JornadaController> _logger;

    public JornadaController(ILogger<JornadaController> logger)
    {
        _logger = logger;
    }

    [HttpGet("jornada/")]
    public IActionResult Jornada(string nome)
    {
        if(true)
        {
            return Ok(BuscaJornada());
        }
        //return BadRequest("Invalid Input");   
    }


    private string BuscaJornada()
    {
        return "Jornada Onboarding";
    }

}
