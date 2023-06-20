using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public class PersonsService : IPersonsService
    {
        private IHttpService _httpService;

        public PersonsService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<IEnumerable<Person>> GetAll()
        {
            return _httpService.Get<IEnumerable<Person>>("/Persons");
        }

        public async Task<int> Create(Person Person)
        {
            var result = await _httpService.Post<Person>("/Persons", Person);
            return result.Id;
        }

        public async Task<int> Delete(int id)
        {
            await _httpService.Delete($"/Persons/{id}");
            return id;

        }

        public async Task<int> Update(Person Person)
        {
            var result = await _httpService.Put<Person>($"/Persons/{Person.Id}", Person);
            return result.Id;
        }

        public Task<Person> GetById(int id)
        {
            return _httpService.Get<Person>($"/Persons/{id}");
        }
    }
}
