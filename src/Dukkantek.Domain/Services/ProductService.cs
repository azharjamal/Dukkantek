using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dukkantek.Domain.Models.Inventories;
using Dukkantek.Domain.Interfaces;
using System.Linq;

namespace Dukkantek.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task<Product> Sale(Product product)
        {
            var mproduct = await _productRepository.GetById(product.Id);
            mproduct.Status = Status.Sold;
            await _productRepository.Update(mproduct);
            return mproduct;
        }

        public async Task<Product> ChangeStatus(Product product)
        {
            if (_productRepository.Search(b => b.Status == product.Status &&  b.Id == product.Id).Result.Any())
                return null;
            var mproduct = await _productRepository.GetById(product.Id);
            mproduct.Status = product.Status;
            await _productRepository.Update(mproduct);
            return mproduct;
        }
        public Task<IEnumerable<ProductStatus>> GetProductStatus(int categoryId)
        {
            return  _productRepository.GetProductStatus(categoryId);
        }


        public void Dispose()
        {
            _productRepository?.Dispose();
        }
    }


}
