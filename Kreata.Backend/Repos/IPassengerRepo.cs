using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;

namespace Kreata.Backend.Repos
{
    public interface IPassengerRepo
    {
        Task<List<Passenger>> GetAll();
        Task<Passenger?> GetBy(Guid id);
        Task<ControllerResponse> UpdatePassengerAsync(Passenger passenger);
    }
}
