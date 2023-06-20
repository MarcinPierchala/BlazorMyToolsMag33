using BlazorMyToolsMag33.Models;
using System.Threading.Tasks;

namespace BlazorMyToolsMag33.Services
{
    public interface IPlacesService
    {
        Task<IEnumerable<Place>> GetAll();
        Task<int> Create(Place place);
        Task<int> Delete(int Id);
        Task<int> Update(Place place);
        Task<Place> GetById(int Id);
    }
}
