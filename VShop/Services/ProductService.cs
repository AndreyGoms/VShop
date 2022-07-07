using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Dtos;
using VShop.Models;
using VShop.Repositories;

namespace VShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }       

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {

            var ProductsEntity = await _productRepository.GetAll();
            return _mapper.Map<IEnumerable<ProductDto>>(ProductsEntity);
            
        }

        public async Task<ProductDto> GetProductById(int id)
        {
            var ProductsEntity = await _productRepository.GetById(id);

            return _mapper.Map<ProductDto>(ProductsEntity);
        }

        public async Task AddProduct(ProductDto productDto)
        {
            var productEntity = _mapper.Map<Product>(productDto);
            await _productRepository.Create(productEntity);
            productDto.Id = productEntity.Id;
        }

        public async Task RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
