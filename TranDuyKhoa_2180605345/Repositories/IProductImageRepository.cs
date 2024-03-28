using TranDuyKhoa_2180605345.Models;

namespace TranDuyKhoa_2180605345.Repositories
{
    public interface IProductImageRepository
    {
        Task<IEnumerable<ProductImage>> GetAllAsync();
        Task<ProductImage> GetByIdAsync(int id);
        Task <IEnumerable<ProductImage>> GetByProductIdAsync(int id);

        Task AddAsync(ProductImage productImage);
        Task UpdateAsync(ProductImage productImage);
        Task DeleteAsync(int id);
    }
}
