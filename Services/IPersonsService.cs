using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public interface IPersonsService
    {
        Task<IEnumerable<Person>> GetAll();
        Task<int> Create(Person Person);
        Task<int> Delete(int Id);
        Task<int> Update(Person Person);
        Task<Person> GetById(int Id);
    }
}
