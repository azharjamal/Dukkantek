using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dukkantek.Domain.Models.Inventories;

namespace Dukkantek.Domain.Interfaces
{
    public interface IProductService : IDisposable
    {
        Task<Product> ChangeStatus(Product product);
        Task<Product> Sale(Product product);
        Task<IEnumerable<ProductStatus>> GetProductStatus(int categoryId);
    }

}
