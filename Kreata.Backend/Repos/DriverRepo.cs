using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class DriverRepo : IDriverRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public DriverRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Driver?> GetBy(Guid id)
        {
            return await _dbContext.Drivers.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Driver>> GetAll()
        {
            return await _dbContext.Drivers.ToListAsync();
        }
        public async Task<ControllerResponse> UpdateDriverAsync(Driver driver)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();

            _dbContext.Entry(driver).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(DriverRepo)} osztály, {nameof(UpdateDriverAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{driver} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
