using Microsoft.AspNetCore.Mvc;

namespace journey.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfiabilidadeController : ControllerBase
{
    
    private readonly ILogger<ConfiabilidadeController> _logger;

    public ConfiabilidadeController(ILogger<ConfiabilidadeController> logger)
    {
        _logger = logger;
    }

    // /Confiabilidade/jornada/mock
    [HttpGet("jornada/{nome}")]
    public IActionResult Jornada(string nome)
    {
        if(true)
        {
            return Ok(BuscaJornada(nome));
        }
        return BadRequest("Invalid Input");   
    }


    private string BuscaJornada(string nome)
    {
        return "Jornada Onboarding";
    }


}
