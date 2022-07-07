using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Dtos;

namespace VShop.Services
{
    interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();        
        Task<ProductDto> GetProductById(int id);
        Task AddProduct(ProductDto productDto);
        Task UpdateProduct(ProductDto productDto);
        Task RemoveProduct(int id);
    }
}
