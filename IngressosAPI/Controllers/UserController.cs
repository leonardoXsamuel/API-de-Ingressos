using IngressosAPI.DTOs.UserDTOs;
using IngressosAPI.Services;
using IngressosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IngressosAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }

    // GET api/<UserController>/5
    [HttpGet("{id}")]
    public async Task<UserResponseDTO> GetUserById(long id)
    {
        return await _service.GetUserAsync(id);
    }

    // POST api/<UserController>
    [HttpPost]
    public async Task<UserResponseDTO> PostUser([FromBody] UserCreateDTO userCreateDTO)
    {
        return await _service.PostUser(userCreateDTO);
    }

    //// PUT api/<UserController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<UserController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
