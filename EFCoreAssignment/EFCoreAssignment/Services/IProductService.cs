using EFCoreAssignment.DTOs;
using EFCoreAssignment.Models;

namespace EFCoreAssignment.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(ProductDto product);
        void UpdateProduct(int id, ProductDto product);
        void DeleteProduct(int id);
    }

}
