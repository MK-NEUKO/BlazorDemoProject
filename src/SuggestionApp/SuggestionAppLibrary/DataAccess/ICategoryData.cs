namespace SuggestionAppLibrary.DataAccess;

public interface ICategoryData
{
    Task<List<CategoryModel>> GetAllCategories();
    Task CreateCategories(CategoryModel category);
}