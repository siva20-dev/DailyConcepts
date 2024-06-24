using Day25Concepts.Models;
using System.Collections.Generic;

namespace Day25Concepts.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();

        string GetName();
    }
}