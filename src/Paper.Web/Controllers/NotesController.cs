using Microsoft.AspNetCore.Mvc;

namespace Paper.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    [HttpGet]
    public List<Note> Get()
    {
        return new List<Note>();
    }
}