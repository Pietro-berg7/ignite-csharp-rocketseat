using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Response;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController: ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new User
        {
            Id = 1,
            Name = "John",
            Age = 7
        };

        return Ok(response);
    }

    [HttpPost]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisterUserJson
        {
            Id = 1,
            Name = request.Name
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John",
                Age = 7
            },
            new User
            {
                Id = 2,
                Name = "Doe",
                Age = 8
            }
        };

        return Ok(response);
    }

    [HttpPut("change-password")] 
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChancePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }
}
