using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController: ControllerBase
{
    [HttpGet]
    //[Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult Get([FromHeader] int id, [FromHeader] string? nickname)
    {
        var response = new User
        {
            Id = 1,
            Name = "John",
            Age = 7
        };

        return Ok(response);
    }
}
