using AssigmentBackend.Business;
using AssigmentBackend.Business.DTOs;
using AssigmentBackend.Business.Filters;
using AssigmentBackend.Model;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentBackend.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly RoomGetService _roomGetService;

        public RoomsController()
        {
            _roomGetService = new RoomGetService();
        }

        [HttpGet("{id}")]
        public Task<Room> Get(int id)
        {
            return _roomGetService.GetAsync(id);
        }

        [HttpGet]
        public Task<List<Room>> GetAll()
        {
            return _roomGetService.GetAllAsync();
        }

        [HttpPost("Availability")]
        public Task<List<RoomAvailability>> GetAvailability([FromBody] RoomAvailabilityFilters filters)
        {
            throw new NotImplementedException();
        }
    }
}