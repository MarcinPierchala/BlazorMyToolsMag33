using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public interface IToolCategoriesService
    {
        Task<IEnumerable<ToolCategory>> GetAll();
        Task<int> Create(ToolCategory toolCategory);
        Task<int> Delete(int Id);
        Task<int> Update(ToolCategory toolCategory);
        Task<ToolCategory> GetById(int Id);
    }
}
