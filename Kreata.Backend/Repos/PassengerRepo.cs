using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class PassengerRepo : IPassengerRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public PassengerRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Passenger?> GetBy(Guid id)
        {
            return await _dbContext.Passengers.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Passenger>> GetAll()
        {
            return await _dbContext.Passengers.ToListAsync();
        }

        public async Task<ControllerResponse> UpdatePassengerAsync(Passenger passenger)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();

            _dbContext.Entry(passenger).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.AppendNewError(ex.Message);
                response.AppendNewError($"{nameof(PassengerRepo)} osztály, {nameof(UpdatePassengerAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{passenger} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
