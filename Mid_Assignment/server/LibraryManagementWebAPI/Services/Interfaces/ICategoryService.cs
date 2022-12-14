using LibraryManagementWebAPI.Models.DTOs.Category;

namespace LibraryManagementWebAPI.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<GetCategoryResponse>> GetAllAsync();
        public Task<GetCategoryResponse?> GetByIdAsync(int id);
        public Task<CreateCategoryResponse?> CreateAsync(CreateCategoryRequest requestModel);
        public Task<UpdateCategoryResponse?> UpdateAsync(UpdateCategoryRequest requestModel);
        public Task<bool> DeleteAsync(int id);
    }
}