using IngressosAPI.DTOs.TicketDTOs;
using IngressosAPI.Services;
using IngressosAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IngressosAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly ITicketService _service;

    public TicketController(TicketService service)
    {
        _service = service;
    }

    // GET api/<TicketController>/5
    [HttpGet("{id}")]
    public async Task<TicketResponseDTO> GetTicketById(long id)
    {
        return await _service.GetTicketAsyncById(id);
    }

    // POST api/<TicketController>
    [HttpPost]
    public async Task<TicketResponseDTO> BuyTicket([FromBody] TicketCreateDTO ticket)
    {
        return await _service.BuyTicket(ticket);
    }

    //// PUT api/<TicketController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<TicketController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
