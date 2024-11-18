using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;

namespace Kreata.Backend.Repos
{
    public interface IDriverRepo
    {
        Task<List<Driver>> GetAll();
        Task<Driver?> GetBy(Guid id);
        Task<ControllerResponse> UpdateDriverAsync(Driver driver);
    }
}
