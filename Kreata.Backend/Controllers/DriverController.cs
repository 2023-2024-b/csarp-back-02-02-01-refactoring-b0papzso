using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class DriverController : ControllerBase
        {
            private IDriverRepo _DriverRepo;
            public DriverController(IDriverRepo DriverRepo)
            {
                _DriverRepo = DriverRepo;
            }
            [HttpGet("{id}")]
            public async Task<IActionResult> GetBy(Guid id)
            {
                Driver? entity = new();
                if (_DriverRepo is not null)
                {
                    entity = await _DriverRepo.GetBy(id);
                    if (entity != null)
                        return Ok(entity);
                }
                return BadRequest("Az adatok elérhetetlenek!");
            }
            [HttpGet]
            public async Task<IActionResult> SelectAllRecordToListAsync()
            {
                List<Driver>? users = new();
                if (_DriverRepo != null)
                {
                    users = await _DriverRepo.GetAll();
                    return Ok(users);
                }
                return BadRequest("Az adatok elérhetetlenek!");
            }

        [HttpPut]
        public async Task<ActionResult> UpdateDriverAsync(Driver entity)
        {
            ControllerResponse response = new();
            if (_DriverRepo is not null)
            {
                response = await _DriverRepo.UpdateDriverAsync(entity);
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
