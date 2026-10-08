using IngressosAPI.DTOs.EventDTOs;
using IngressosAPI.Services;
using IngressosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IngressosAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController : ControllerBase
{
    public readonly IEventService _service;

    public EventController(EventService service)
    {
        _service = service;
    }

    // GET api/<EventController>/5
    [HttpGet("{id}")]
    public async Task<EventResponseDTO> GetEventById(long id)
    {
        return await _service.GetEventAsyncById(id);
    }

    // POST api/<EventController>
    [HttpPost]
    public async Task<EventResponseDTO> PostEvent([FromBody] EventCreateDTO eventCreateDTO)
    {
        return await _service.CreateEvent(eventCreateDTO);
    }

    // PUT api/<EventController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    // DELETE api/<EventController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
