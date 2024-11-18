using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassengerController : ControllerBase
    {
        private IPassengerRepo _PassengerRepo;
        public PassengerController(IPassengerRepo PassengerRepo)
        {
            _PassengerRepo = PassengerRepo;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Passenger? entity = new();
            if (_PassengerRepo is not null)
            {
                entity = await _PassengerRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Passenger>? users = new();
            if (_PassengerRepo != null)
            {
                users = await _PassengerRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpPut]
        public async Task<ActionResult> UpdatePassengerAsync(Passenger entity)
        {
            ControllerResponse response = new();
            if (_PassengerRepo is not null)
            {
                response = await _PassengerRepo.UpdatePassengerAsync(entity);
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else { return Ok(response); }
            }
            response.ClearAndAddError("Az adatok frissítése nem lehetséges!");
            return BadRequest(response);
        }
    }
}
