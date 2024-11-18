using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;

using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;
using Kreata.Backend.Datas.Responses;

namespace Kreata.Backend.Repos
{
    public class AdminRepo : IAdminRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public AdminRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Admin?> GetBy(Guid id)
        {
            return await _dbContext.Admins.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Admin>> GetAll()
        {
            return await _dbContext.Admins.ToListAsync();
        }
        public async Task<ControllerResponse> UpdateAdminAsync(Admin admin)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();

            _dbContext.Entry(admin).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(AdminRepo)} osztály, {nameof(UpdateAdminAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{admin} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
