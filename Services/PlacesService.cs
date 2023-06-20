using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public class PlacesService : IPlacesService
    {
        private IHttpService _httpService;

        public PlacesService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<IEnumerable<Place>> GetAll()
        {
            return _httpService.Get<IEnumerable<Place>>("/Places");
        }

        public async Task<int> Create(Place Place)
        {
            var result = await _httpService.Post<Place>("/Places", Place);
            return result.Id;
        }

        public async Task<int> Delete(int id)
        {
            await _httpService.Delete($"/Places/{id}");
            return id;

        }

        public async Task<int> Update(Place Place)
        {
            var result = await _httpService.Put<Place>($"/Places/{Place.Id}", Place);
            return result.Id;
        }

        public Task<Place> GetById(int id)
        {
            return _httpService.Get<Place>($"/Places/{id}");
        }
    }
}
