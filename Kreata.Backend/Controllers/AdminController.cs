using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private IAdminRepo _AdminRepo;
        public AdminController(IAdminRepo AdminRepo)
        {
            _AdminRepo = AdminRepo;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Admin? entity = new();
            if (_AdminRepo is not null)
            {
                entity = await _AdminRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Admin>? users = new();
            if (_AdminRepo != null)
            {
                users = await _AdminRepo.GetAll();
                return Ok(users);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAdminAsync(Admin entity)
        {
            ControllerResponse response = new();
            if (_AdminRepo is not null)
            {
                response = await _AdminRepo.UpdateAdminAsync(entity);
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
