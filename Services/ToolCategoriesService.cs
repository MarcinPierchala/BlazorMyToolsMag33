using BlazorMyToolsMag33.Models;

namespace BlazorMyToolsMag33.Services
{
    public class ToolCategoriesService : IToolCategoriesService
    {
        private IHttpService _httpService;

        public ToolCategoriesService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public Task<IEnumerable<ToolCategory>> GetAll()
        {
            return _httpService.Get<IEnumerable<ToolCategory>>("/ToolCategories");
        }

        public async Task<int> Create(ToolCategory toolCategory)
        {
            var result = await _httpService.Post<ToolCategory>("/ToolCategories", toolCategory);
            return result.Id;
        }

        public async Task<int> Delete(int id)
        {
            await _httpService.Delete($"/ToolCategories/{id}");
            return id;

        }

        public async Task<int> Update(ToolCategory toolCategory)
        {
            var result = await _httpService.Put<ToolCategory>($"/ToolCategories/{toolCategory.Id}", toolCategory);
            return toolCategory.Id;
        }

        public Task<ToolCategory> GetById(int id)
        {
            return _httpService.Get<ToolCategory>($"/ToolCategories/{id}");
        }
    }
}
